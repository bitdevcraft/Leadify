import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { catchError, throwError } from 'rxjs';
import { AppToastService } from '../../../layout/service/app.toast.service';

export const errorInterceptor: HttpInterceptorFn = (req, next) => {
  const toastService = inject(AppToastService);

  return next(req).pipe(
    catchError((error: HttpErrorResponse) => {
      error?.error?.errors?.forEach((e) => {
        console.log(e.description);
        toastService.sendToast({
          severity: 'error',
          summary: e.description,
          detail: 'Error',
        });
      });

      let errorMessage = 'An unknown error occurred!';
      if (error.error instanceof ErrorEvent) {
        errorMessage = `Error: ${error.error.message}`;
      } else {
        errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
      }

      return throwError(() => {
        return {
          error: new Error(errorMessage),
          status: error.status,
        };
      });
    }),
  );
};
