import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { ButtonGroupModule } from 'primeng/buttongroup';
import { TableModule } from 'primeng/table';

interface Column {
  field: string;
  header: string;
}

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [
    TableModule,
    CommonModule,
    ButtonModule,
    ButtonGroupModule,
    RouterModule,
  ],
  templateUrl: './user.component.html',
  styleUrl: './user.component.scss',
})
export class AppUserComponent implements OnInit {
  cols!: Column[];

  records!: any[];

  ngOnInit(): void {
    this.cols = [
      { field: 'userName', header: 'Username' },
      { field: 'fullName', header: 'Full Name' },
      { field: 'role', header: 'Role' },
      { field: 'active', header: 'Active' },
    ];
  }
}
