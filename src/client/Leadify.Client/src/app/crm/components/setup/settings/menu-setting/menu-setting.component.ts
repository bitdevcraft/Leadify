import { CommonModule, NgClass } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { CUSTOM_ELEMENTS_SCHEMA, Component, OnInit } from '@angular/core';
import {
  ConfirmationService,
  MenuItem,
  MessageService,
  SharedModule,
  TreeDragDropService,
  TreeNode,
} from 'primeng/api';
import { ButtonModule } from 'primeng/button';
import { ContextMenuModule } from 'primeng/contextmenu';
import { DialogModule } from 'primeng/dialog';
import { SelectButtonModule } from 'primeng/selectbutton';
import { ToastModule } from 'primeng/toast';
import { TreeModule } from 'primeng/tree';
import { TreeTableModule } from 'primeng/treetable';
import { ulid } from 'ulid';
import { ButtonGroupModule } from 'primeng/buttongroup';
import { ToggleButtonModule } from 'primeng/togglebutton';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { MenuSettingService } from './menu-setting.service';
import { MenuConfig } from '../../../../../layout/api/menu';
import { InputTextModule } from 'primeng/inputtext';
import { DropdownModule } from 'primeng/dropdown';
import { IconsService } from '../../../../services/icons.service';
import { ConfirmDialogModule } from 'primeng/confirmdialog';

interface MenuDetail extends TreeNode {
  id?: string;
  routerLink?: string[];
  url?: string[];
  target?: string;
  children?: MenuDetail[];
  label?: string;
  hierarchy?: number;
  canDelete?: boolean;
}

interface DDOption {
  label: string;
  value: string;
}

@Component({
  selector: 'app-menu-setting',
  standalone: true,
  imports: [
    TreeModule,
    TreeTableModule,
    SharedModule,
    ButtonModule,
    CommonModule,
    ContextMenuModule,
    ToastModule,
    DialogModule,
    SelectButtonModule,
    ButtonGroupModule,
    ToggleButtonModule,
    FormsModule,
    InputTextModule,
    ReactiveFormsModule,
    DropdownModule,
    NgClass,
    ConfirmDialogModule,
  ],
  providers: [MessageService, TreeDragDropService, ConfirmationService],
  templateUrl: './menu-setting.component.html',
  styleUrl: './menu-setting.component.scss',
})
export class MenuSettingComponent implements OnInit {
  formGroup: FormGroup | undefined;

  menus: MenuDetail[] = [
    {
      label: 'App',
      data: 'root',
      expanded: true,
      droppable: true,
      canDelete: false,
    },
  ];

  draggable: boolean = false;

  selectedFile!: MenuDetail | null;

  items!: MenuItem[];
  icons: DDOption[] | undefined;
  selectedIcon: DDOption | undefined;

  newMenuDialog: boolean = false;
  newDirectoryDialog: boolean = false;

  menuTypeValue: string = 'off';
  menuTypeOptions: any[] = [
    { label: 'Path', value: 'path' },
    { label: 'Directory', value: 'directory' },
  ];

  constructor(
    private http: HttpClient,
    private messageService: MessageService,
    private menuSettingService: MenuSettingService,
    private iconService: IconsService,
    private confirmationService: ConfirmationService,
  ) {}

  ngOnInit(): void {
    this.http.get<MenuDetail[]>('/api/app/menuTree').subscribe((data: any) => {
      this.menus[0].children = data;
    });

    this.iconService.getIcons().then((data) => (this.icons = data));

    this.items = [
      {
        label: 'New',
        icon: 'pi pi-plus',
        items: [
          {
            label: 'Menu',
            command: (event) => this.newMenu(this.selectedFile),
          },
          {
            label: 'Directory',
            command: (event) => this.newDirectory(this.selectedFile),
          },
        ],
      },
      {
        label: 'View',
        icon: 'pi pi-search',
        command: (event) => this.viewMenu(this.selectedFile),
      },
      {
        separator: true,
      },
      {
        label: 'Delete',
        icon: 'pi pi-trash',
        styleClass: 'p-error',
        command: (event) => this.deleteConfirm(event as Event),
      },
    ];

    this.formGroup = new FormGroup({
      label: new FormControl<string>('Name'),
      routerLink: new FormControl<string | null>(null),
      selectedIcon: new FormControl<DDOption | null>(null),
    });
  }

  onSubmit() {
    if (this.formGroup.valid) {
      const newId = ulid();

      const link = this.newMenuDialog
        ? [this.formGroup.value.routerLink ?? '/']
        : null;

      const newMenu: MenuDetail = {
        label: this.formGroup.value.label,
        id: newId,
        key: newId,
        icon: `pi pi-fw ${this.formGroup.value.selectedIcon?.value}`,
        routerLink: link,
        droppable: this.newDirectoryDialog,
        children: this.newDirectoryDialog ? [] : null,
        hierarchy: this.selectedFile.children?.length ?? 0,
      };

      this.menuSettingService
        .newMenu(this.selectedFile.id, newMenu as MenuConfig)
        .subscribe(
          (response) => {
            console.log(response);
            if (!this.selectedFile.children) this.selectedFile.children = [];
            this.selectedFile.children.push(newMenu);
            this.selectedFile.expanded = true;
          },
          (error) => {
            console.log('error new menu', error);
          },
        );
    }

    this.newMenuDialog = false;
    this.newDirectoryDialog = false;
    this.selectedIcon = undefined;
  }

  viewMenu(file: MenuDetail) {
    console.log(file);

    if (!file.routerLink && !file.url)
      this.messageService.add({
        severity: 'info',
        summary: 'Node Details',
        detail: file.label,
      });
  }

  newMenu(file: MenuDetail) {
    console.log(file);

    if (!file.droppable) {
      this.messageService.add({
        severity: 'error',
        summary: `Invalid Directory`,
        detail: file.label,
      });

      return;
    }

    this.newMenuDialog = !this.newMenuDialog;
  }

  newDirectory(file: MenuDetail) {
    console.log(file);

    if (!file.droppable) {
      this.messageService.add({
        severity: 'error',
        summary: `Invalid Directory`,
        detail: file.label,
      });

      return;
    }

    this.newDirectoryDialog = !this.newDirectoryDialog;
  }

  deleteMenu(file: MenuDetail) {
    this.menuSettingService.deleteMenu(file.id).subscribe(
      (response) => {
        this.deleteLeafNode(this.menus, file.id);
        this.unselectFile();
      },
      (error) => {
        console.error(error);
      },
    );
  }

  deleteLeafNode(menu: MenuDetail[], idToDelete: string): MenuDetail[] {
    return menu.reduce<MenuDetail[]>((acc, item) => {
      if (item.children && item.children.length > 0) {
        item.children = this.deleteLeafNode(item.children, idToDelete);
      }

      if (
        item.id === idToDelete &&
        (!item.children || item.children.length === 0)
      ) {
        return acc;
      } else {
        acc.push(item);
        return acc;
      }
    }, []);
  }

  unselectFile() {
    this.selectedFile = null;
  }

  expandAll() {
    this.menus.forEach((node) => {
      this.expandRecursive(node, true);
    });
  }

  collapseAll() {
    this.menus.forEach((node) => {
      this.expandRecursive(node, false);
    });
  }

  private expandRecursive(node: TreeNode, isExpand: boolean) {
    node.expanded = isExpand;
    if (node.children) {
      node.children.forEach((childNode) => {
        this.expandRecursive(childNode, isExpand);
      });
    }
  }

  nodeDrop(event: any) {
    console.log('Drag', event.dragNode.label);
    console.log('Drop', event.dropNode.label);
    this.messageService.add({
      severity: 'info',
      summary: 'Node Drop',
      detail: event.dragNode.label,
    });
  }

  deleteConfirm(event: Event) {
    if (!this.selectedFile.canDelete) {
      this.messageService.add({
        severity: 'error',
        summary: `System Menu cannot be deleted`,
        detail: this.selectedFile.label,
      });
      return;
    }
    if (this.selectedFile.children?.length > 0) {
      this.messageService.add({
        severity: 'error',
        summary: 'Directory has existing items',
        detail: this.selectedFile.label,
      });
      return;
    }

    this.confirmationService.confirm({
      target: event.target as EventTarget,
      message: `Do you want to delete this item "${this.selectedFile.label}"?`,
      header: 'Delete Confirmation',
      icon: 'pi pi-info-circle',
      acceptButtonStyleClass: 'p-button-danger p-button-text',
      rejectButtonStyleClass: 'p-button-text p-button-text',
      acceptIcon: 'none',
      rejectIcon: 'none',

      accept: () => {
        this.deleteMenu(this.selectedFile);
      },
      reject: () => {},
    });
  }
}
