import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {
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

interface MenuDetail extends TreeNode {
  id?: string;
  routerLink?: string[];
  url?: string[];
  target?: string;
  children?: MenuDetail[];
  label?: string;
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
  ],
  providers: [MessageService, TreeDragDropService],
  templateUrl: './menu-setting.component.html',
  styleUrl: './menu-setting.component.scss',
})
export class MenuSettingComponent implements OnInit {
  menus: MenuDetail[] = [
    {
      label: 'App',
      data: 'root',
      expanded: true,
      droppable: true,
    },
  ];

  selectedFile!: MenuDetail | null;

  items!: MenuItem[];

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
  ) {}

  ngOnInit(): void {
    this.http.get<MenuDetail[]>('/api/app/menuTree').subscribe((data: any) => {
      this.menus[0].children = data;
    });

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
        command: (event) => this.deleteMenu(this.selectedFile),
      },
    ];
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
    // const newId = ulid();
    // file.children.push({
    //   label: 'New Test',
    //   id: newId,
    //   key: newId,
    // });
    //
    // file.expanded = true;
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
    // const newId = ulid();
    // file.children.push({
    //   label: 'New Test',
    //   id: newId,
    //   key: newId,
    // });
    //
    // file.expanded = true;
  }

  deleteMenu(file: MenuDetail) {
    console.log(file);

    if (file.children?.length > 0) {
      this.messageService.add({
        severity: 'error',
        summary: 'Directory has children',
        detail: file.label,
      });
      return;
    }
    console.log('@@@ Id', file.id);

    this.deleteLeafNode(this.menus, file.id);

    console.log('Finished');

    this.unselectFile();
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
}
