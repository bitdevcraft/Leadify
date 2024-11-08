import { CommonModule, CurrencyPipe, DatePipe } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextModule } from 'primeng/inputtext';
import { MultiSelectModule } from 'primeng/multiselect';
import { ProgressBarModule } from 'primeng/progressbar';
import { Table, TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { switchMap } from 'rxjs';

@Component({
  selector: 'app-list-view',
  standalone: true,
  imports: [
    TableModule,
    HttpClientModule,
    CommonModule,
    InputTextModule,
    TagModule,
    DropdownModule,
    MultiSelectModule,
    ProgressBarModule,
    ButtonModule,
    CurrencyPipe,
    DatePipe,
  ],
  templateUrl: './list-view.component.html',
  styleUrl: './list-view.component.scss',
})
export class ListViewComponent implements OnInit {
  objectName: string;
  records!: any[];
  loading: boolean = false;
  searchValue: string | undefined;

  @ViewChild('filter') filter!: ElementRef;

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.objectName = params.get('object');
    });
  }

  onGlobalFilter(table: Table, event: Event) {
    table.filterGlobal((event.target as HTMLInputElement).value, 'contains');
  }

  clear(table: Table) {
    table.clear();
    this.filter.nativeElement.value = '';
  }
}
