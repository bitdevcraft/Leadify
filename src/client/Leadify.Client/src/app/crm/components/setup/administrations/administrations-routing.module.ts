import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'permission',
    loadComponent: () =>
      import('./permission/permission.component').then(
        (c) => c.PermissionComponent,
      ),
  },
  {
    path: 'user',
    loadComponent: () =>
      import('./users/user/user.component').then((c) => c.AppUserComponent),
  },
  {
    path: 'user/new',
    loadComponent: () =>
      import('./users/create-user/create-user.component').then(
        (c) => c.CreateUserComponent,
      ),
  },
  {
    path: 'role',
    loadComponent: () =>
      import('./role/role.component').then((c) => c.RoleComponent),
  },
  { path: '**', redirectTo: '/notfound' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdministrationsRoutingModule {}
