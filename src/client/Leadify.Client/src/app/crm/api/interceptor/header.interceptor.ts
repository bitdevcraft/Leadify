import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { AuthService } from '../../components/auth/auth.service';
import { inject } from '@angular/core';
import { catchError, of, switchMap } from 'rxjs';
import { Router } from '@angular/router';

export const headerInterceptor: HttpInterceptorFn = (req, next) => {
  const authToken = localStorage.getItem('authToken');
  const authService = inject(AuthService);
  const router = inject(Router);

  // if (authToken) {
  //   req = req.clone({
  //     setHeaders: {
  //       Authorization: `Bearer ${authToken}`,
  //     }
  //   });
  // }

  return next(req).pipe(
    catchError((error: HttpErrorResponse) => {
      console.log('Header Interceptor', error);
      if (error.status === 401) {
        console.log('Expire JWT');
        return authService.refreshAccessToken().pipe(
          switchMap((data) => {
            const newAccessToken = data.token;
            localStorage.setItem('authToken', newAccessToken);

            const newRequest = req.clone({
              setHeaders: {
                Authorization: `Bearer ${newAccessToken}`,
              },
            });

            return next(newRequest);
          }),
          catchError((refreshError) => {
            authService.logout(router.url);
            return of(refreshError);
          }),
        );
      }
      return of(error);
    }),
  );
};
