import {CanActivateFn, Router} from '@angular/router';
import {AuthService} from "./auth.service";
import {inject} from '@angular/core';
import {map} from 'rxjs';

export const authGuard: CanActivateFn = (route, state) => {
  const authService = inject(AuthService);
  const router = inject(Router);

  return authService.isLoggedIn$.pipe(
    map(isLoggedIn => {
      if (!isLoggedIn) {

        // User is not logged in, redirect to login page with the return URL and return false
        router.navigate(['/auth/login'], {queryParams: {returnUrl: state.url}});
      }
      return isLoggedIn;
    })
  );
};
