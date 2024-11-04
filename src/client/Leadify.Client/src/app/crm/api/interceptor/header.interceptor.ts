import {HttpInterceptorFn} from '@angular/common/http';

export const headerInterceptor: HttpInterceptorFn = (req, next) => {

    const authToken = localStorage.getItem('authToken');

    if (authToken) {
        req = req.clone({
            setHeaders: {
                Authorization: `Bearer ${authToken}`,
            }
        });
    }

    return next(req);
};
