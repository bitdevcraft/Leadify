import {Component} from '@angular/core';
import {LayoutService} from 'src/app/layout/service/app.layout.service';
import {Router, RouterLink} from '@angular/router';
import {ButtonModule} from 'primeng/button';
import {CheckboxModule} from 'primeng/checkbox';
import {FormsModule} from '@angular/forms';
import {PasswordModule} from 'primeng/password';
import {InputTextModule} from 'primeng/inputtext';
import {HttpClient} from '@angular/common/http';
import {CommonModule, NgIf} from '@angular/common';
import {AuthService} from "../auth.service";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: [
    `
      :host ::ng-deep .pi-eye,
      :host ::ng-deep .pi-eye-slash {
        transform: scale(1.6);
        margin-right: 1rem;
        color: var(--primary-color) !important;
      }
    `,
  ],
  standalone: true,
  imports: [InputTextModule, PasswordModule, FormsModule, CheckboxModule, ButtonModule, RouterLink, CommonModule],
})
export class LoginComponent {
  valCheck: string[] = ['remember'];

  password!: string;
  username!: string;

  constructor(public layoutService: LayoutService, private authService: AuthService) {
  }

  login() {
    this.authService.login({username: this.username, password: this.password});
  }


}
