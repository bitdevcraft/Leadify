import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
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

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.cols = [
      { field: 'userName', header: 'Username' },
      { field: 'fullName', header: 'Full Name' },
      { field: 'role', header: 'Role' },
      { field: 'active', header: 'Active' },
    ];

    this.refreshUserList();
  }

  refreshUserList() {
    this.http.get<any[]>('/api/user').subscribe((data: any) => {
      this.records = data;
    });
  }
}
