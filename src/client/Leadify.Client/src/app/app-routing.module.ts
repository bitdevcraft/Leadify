import {
  ExtraOptions,
  InMemoryScrollingFeature,
  provideRouter,
  RouterModule,
  withInMemoryScrolling,
} from '@angular/router';
import {NgModule} from '@angular/core';
import {NotfoundComponent} from './demo/components/notfound/notfound.component';
import {AppLayoutComponent} from './layout/app.layout.component';
import {authGuard} from "./crm/components/auth/auth.guard";

export const routes = [
  {
    path: '',
    component: AppLayoutComponent,
    canActivate: [authGuard],
    children: [
      {
        path: '',
        loadChildren: () =>
          import('./demo/components/dashboard/dashboard.module').then((m) => m.DashboardModule),
      },
      {
        path: 'uikit',
        loadChildren: () =>
          import('./demo/components/uikit/uikit.module').then((m) => m.UIkitModule),
      },
      {
        path: 'utilities',
        loadChildren: () =>
          import('./demo/components/utilities/utilities.module').then((m) => m.UtilitiesModule),
      },
      {
        path: 'documentation',
        loadChildren: () =>
          import('./demo/components/documentation/documentation.module').then(
            (m) => m.DocumentationModule,
          ),
      },
      {
        path: 'blocks',
        loadChildren: () =>
          import('./demo/components/primeblocks/primeblocks.module').then(
            (m) => m.PrimeBlocksModule,
          ),
      },
      {
        path: 'pages',
        loadChildren: () =>
          import('./demo/components/pages/pages.module').then((m) => m.PagesModule),
      },
    ],
  },
  {
    path: 'demo-auth',
    loadChildren: () => import('./demo/components/auth/auth.module').then((m) => m.AuthModule),
  }, {
    path: 'auth',
    loadChildren: () => import('./crm/components/auth/auth.module').then((m) => m.AuthModule),
  },
  {
    path: 'landing',
    loadChildren: () =>
      import('./demo/components/landing/landing.module').then((m) => m.LandingModule),
  },
  {path: 'notfound', component: NotfoundComponent},
  {path: '**', redirectTo: '/notfound'},
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      scrollPositionRestoration: 'enabled',
      anchorScrolling: 'enabled',
      onSameUrlNavigation: 'reload',
    }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {
}

const scrollConfig: ExtraOptions = {
  scrollPositionRestoration: 'enabled',
  anchorScrolling: 'enabled',
  onSameUrlNavigation: 'reload',
};

const inMemoryScrollingFeature: InMemoryScrollingFeature = withInMemoryScrolling(scrollConfig);

export const routingProviders = [provideRouter(routes, inMemoryScrollingFeature)];
