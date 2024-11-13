import { inject } from '@angular/core';
import { CanActivateChildFn, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { AuthService } from '../../components/auth/auth.service';

export const roleGuard: CanActivateChildFn = (childRoute, state) => {
  const jwtHelper = inject(JwtHelperService);
  const authService = inject(AuthService);
  const router = inject(Router);

  const roles = jwtHelper
    .decodeToken(authService.accessToken())
    ?.roles?.split(',');

  if (roles?.some((role) => role.toUpperCase() === 'SYSTEMADMINISTRATOR')) {
    return true;
  } else {
    router.navigate(['/']);
    return false;
  }
};
