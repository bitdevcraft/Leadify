import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { FieldsetModule } from 'primeng/fieldset';
import { InputMaskModule } from 'primeng/inputmask';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';

@Component({
  selector: 'app-create-user',
  standalone: true,
  imports: [
    InputTextModule,
    ButtonModule,
    InputTextareaModule,
    DropdownModule,
    FormsModule,
    InputMaskModule,
    FieldsetModule,
  ],
  templateUrl: './create-user.component.html',
  styleUrl: './create-user.component.scss',
})
export class CreateUserComponent {
  email!: string;
  selectSalutation: any = null;

  salutations = [
    { name: 'Mr.', code: 'Mr.' },
    { name: 'Ms.', code: 'Ms.' },
    { name: 'Mrs.', code: 'Mrs.' },
    { name: 'Dr.', code: 'Dr.' },
    { name: 'Prof.', code: 'Prof.' },
    { name: 'Mx.', code: 'Mx.' },
  ];
}
