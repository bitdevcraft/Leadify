import { Component } from '@angular/core';
import { FieldsetModule } from 'primeng/fieldset';

@Component({
  selector: 'app-user-details',
  standalone: true,
  imports: [FieldsetModule],
  templateUrl: './user-details.component.html',
  styleUrl: './user-details.component.scss',
})
export class UserDetailsComponent {}
