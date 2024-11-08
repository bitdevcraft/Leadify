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
      import('./user/user.component').then((c) => c.UserComponent),
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
