import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: ':object/:id/view',
    loadComponent: () =>
      import('./record-details/record-details.component').then(
        (c) => c.RecordDetailsComponent,
      ),
  },
  {
    path: ':object/list-view',
    loadComponent: () =>
      import('./list-view/list-view.component').then(
        (c) => c.ListViewComponent,
      ),
  },
  {
    path: ':object/new',
    loadComponent: () =>
      import('./new-record/new-record.component').then(
        (c) => c.NewRecordComponent,
      ),
  },
  { path: '**', redirectTo: '/notfound' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ObjectRoutingModule {}
