import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { AuthService } from '../../components/auth/auth.service';
import { inject } from '@angular/core';
import { catchError, mergeMap, of, switchMap, take } from 'rxjs';
import { Router } from '@angular/router';

export const headerInterceptor: HttpInterceptorFn = (req, next) => {
  const authToken = localStorage.getItem('authToken');
  const authService = inject(AuthService);
  const router = inject(Router);

  return authService.token$.pipe(
    take(1),
    mergeMap((token) => {
      if (token) {
        // If there is a token, clone the request and add the Authorization header
        req = req.clone({
          setHeaders: {
            Authorization: `Bearer ${token}`,
          },
        });
      }

      return next(req).pipe(
        catchError((error: HttpErrorResponse) => {
          if (error.status === 401) {
            return authService.refreshAccessToken().pipe(
              switchMap((data) => {
                const newAccessToken = data.token;

                authService.setToken(newAccessToken);

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
    }),
  );
};
