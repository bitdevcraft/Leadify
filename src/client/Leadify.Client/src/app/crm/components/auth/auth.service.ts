import {Injectable, inject} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Router} from '@angular/router';
import {BehaviorSubject} from 'rxjs';
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
    this.http.post<userToken>('/api/auth/login', credentials).subscribe(
      (data) => {
        this.token = data.token;
        localStorage.setItem('authToken', this.token);
        this.isAuthenticated.next(true);
        this.router.navigateByUrl(returnUrl);
      },
      (error) => {
        console.log(error);
      }
    )
  }

  logout(returnUrl: string = '/') {
    this.token = null;
    localStorage.removeItem('authToken');
    this.isAuthenticated.next(false);
    this.router.navigate(['/auth/login'], {queryParams: {returnUrl: returnUrl}});
  }
}
