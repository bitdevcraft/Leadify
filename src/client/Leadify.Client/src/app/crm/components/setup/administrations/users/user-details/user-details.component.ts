import { Component } from '@angular/core';
import { FieldsetModule } from 'primeng/fieldset';

@Component({
  selector: 'app-user-details',
  standalone: true,
  imports: [FieldsetModule],
  templateUrl: './user-details.component.html',
})
export class UserDetailsComponent {}
