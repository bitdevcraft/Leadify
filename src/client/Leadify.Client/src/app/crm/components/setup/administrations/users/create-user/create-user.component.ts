import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { ButtonGroupModule } from 'primeng/buttongroup';
import { DropdownModule } from 'primeng/dropdown';
import { FieldsetModule } from 'primeng/fieldset';
import { InputMaskModule } from 'primeng/inputmask';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { AppToastService } from '../../../../../../layout/service/app.toast.service';

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
    RouterModule,
    ButtonGroupModule,
    ReactiveFormsModule,
    CommonModule,
  ],
  templateUrl: './create-user.component.html',
  styleUrl: './create-user.component.scss',
})
export class CreateUserComponent implements OnInit {
  email!: string;
  emailPattern = '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$';

  roles: any[] = [];
  formGroup: FormGroup | undefined;

  salutations = [
    { name: 'Mr.', code: 'Mr.' },
    { name: 'Ms.', code: 'Ms.' },
    { name: 'Mrs.', code: 'Mrs.' },
    { name: 'Dr.', code: 'Dr.' },
    { name: 'Prof.', code: 'Prof.' },
    { name: 'Mx.', code: 'Mx.' },
  ];

  constructor(
    private http: HttpClient,
    private router: Router,
    private toastService: AppToastService,
  ) {}

  ngOnInit(): void {
    this.http.get<string[]>('/api/role').subscribe((data: any) => {
      this.roles = data;
    });

    this.formGroup = new FormGroup({
      userName: new FormControl<string | null>(null, [
        Validators.required,
        Validators.minLength(3),
      ]),
      email: new FormControl<string | null>(null, [
        Validators.required,
        Validators.pattern(this.emailPattern),
      ]),
      lastName: new FormControl<string | null>(null, [Validators.required]),
      firstName: new FormControl<string | null>(null),
      middleName: new FormControl<string | null>(null),
      suffix: new FormControl<string | null>(null),
      salutation: new FormControl<string | null>(null),
      mobile: new FormControl<string | null>(null),
      phone: new FormControl<string | null>(null),
      fax: new FormControl<string | null>(null),
      title: new FormControl<string | null>(null),
      role: new FormControl<string | null>(null, [Validators.required]),
    });
  }

  onSubmit() {
    if (this.formGroup.valid) {
      console.log('Form Submitted!', this.formGroup.value);

      this.http.post<any>('/api/user/create', this.formGroup.value).subscribe(
        (response) => {
          console.log('Success', response);
          this.toastService.sendToast({
            severity: 'success',
            summary: `Successfully Created`,
            detail: 'User',
          });
          this.router.navigate(['/setup/administrations/user']);
        },
        (error) => {
          console.log(error);
        },
      );
    } else {
      console.log('Form is invalid');
      this.formGroup.markAllAsTouched();
    }
  }
}
