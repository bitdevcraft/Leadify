import { enableProdMode, importProvidersFrom } from '@angular/core';

import { environment } from './environments/environment';
import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { routingProviders } from './app/app-routing.module';
import { ProductService } from './app/demo/service/product.service';
import { PhotoService } from './app/demo/service/photo.service';
import { NodeService } from './app/demo/service/node.service';
import { IconService } from './app/demo/service/icon.service';
import { EventService } from './app/demo/service/event.service';
import { CustomerService } from './app/demo/service/customer.service';
import { CountryService } from './app/demo/service/country.service';
import { LocationStrategy, PathLocationStrategy } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  HTTP_INTERCEPTORS,
  HttpClientModule,
  provideHttpClient,
  withInterceptors,
  withInterceptorsFromDi,
} from '@angular/common/http';
import { IdleUserService } from './app/utils/services/idle-user.service';
import { headerInterceptor } from './app/crm/api/interceptor/header.interceptor';
import { errorInterceptor } from './app/crm/api/interceptor/error.interceptor';
import { loggingInterceptor } from './app/crm/api/interceptor/logging.interceptor';
import { JwtModule } from '@auth0/angular-jwt';

if (environment.production) {
  enableProdMode();
}

export function tokenGetter() {
  return localStorage.getItem('authToken');
}

bootstrapApplication(AppComponent, {
  providers: [
    routingProviders,
    importProvidersFrom(
      BrowserAnimationsModule,
      HttpClientModule,
      JwtModule.forRoot({
        config: {
          tokenGetter: tokenGetter,
          allowedDomains: ['https://localhost:7197'],
          disallowedRoutes: ['http://example.com/examplebadroute/'],
        },
      }),
    ),
    { provide: LocationStrategy, useClass: PathLocationStrategy },
    CountryService,
    CustomerService,
    EventService,
    IconService,
    NodeService,
    PhotoService,
    ProductService,
    IdleUserService,
    provideHttpClient(
      // registering interceptors
      withInterceptorsFromDi(),
      withInterceptors([
        headerInterceptor,
        loggingInterceptor,
        errorInterceptor,
      ]),
    ),
  ],
}).catch((err) => console.error(err));
