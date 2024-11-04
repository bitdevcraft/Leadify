import {Injectable, inject} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Router} from '@angular/router';
import {BehaviorSubject, Observable, map, switchMap} from 'rxjs';
import {IdleUserService} from "../../../utils/services/idle-user.service";

interface userToken {
  username: string;
  token: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private isAuthenticated = new BehaviorSubject<boolean>(false);
  isLoggedIn$ = this.isAuthenticated.asObservable();
  private token: string | null = null;


  constructor(private http: HttpClient, private router: Router) {
    // Check for a token in local storage on initialization
    this.token = localStorage.getItem('authToken');
    this.isAuthenticated.next(!!this.token); // Set state based on token existence
  }

  login(credentials: { username: string; password: string }, returnUrl: string) {
    this.http.post<userToken>('/api/auth/login', credentials).pipe(
      switchMap((response) => {
        console.log('Pipe', response);
        this.token = response.token;
        localStorage.setItem('authToken', this.token);
        this.isAuthenticated.next(true);
        this.router.navigateByUrl(returnUrl);

        return this.getIpAddress().pipe(map(response => {
          console.log(response);
          return response;


        }));
      })
    ).subscribe(
      (data) => {
        console.log("IP Address", data);
      })
  }

  logout(returnUrl: string = '/') {
    this.token = null;
    localStorage.removeItem('authToken');
    this.isAuthenticated.next(false);
    this.router.navigate(['/auth/login'], {queryParams: {returnUrl: returnUrl}});
  }

  getIpAddress(): Observable<string> {
    return this.http.get<string>('/ipify?format=json').pipe(
      map((response: any) => {
        console.log('Get IP Address', response);
        return response.ip
      })
    );
  }
}
