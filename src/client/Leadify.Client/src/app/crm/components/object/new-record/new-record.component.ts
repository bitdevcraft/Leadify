import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';

@Component({
  selector: 'app-new-record',
  standalone: true,
  imports: [
    InputTextModule,
    ButtonModule,
    InputTextareaModule,
    DropdownModule,
    FormsModule,
  ],
  templateUrl: './new-record.component.html',
  styleUrl: './new-record.component.scss',
})
export class NewRecordComponent {}
