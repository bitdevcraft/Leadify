import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Router} from '@angular/router';
import {BehaviorSubject} from 'rxjs';

interface userToken {
  username: string;
  token: string;
}

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private isAuthenticated = new BehaviorSubject<boolean>(false);
  private token: string | null = null;

  constructor(private http: HttpClient, private router: Router) {
    // Check for a token in local storage on initialization
    this.token = localStorage.getItem('authToken');
    this.isAuthenticated.next(!!this.token); // Set state based on token existence
  }

  login(credentials: { username: string; password: string }) {
    this.http.post<userToken>('/api/auth/login', credentials).subscribe(
      (data) => {
        this.token = data.token;
        localStorage.setItem('authToken', this.token);
        this.isAuthenticated.next(true);
        this.router.navigate(['/']);
      },
      (error) => {
        console.log(error);
      }
    )
  }

  logout() {
    this.token = null;
    localStorage.removeItem('authToken');
    this.isAuthenticated.next(false);
    this.router.navigate(['/login']);
  }

  isLoggedIn() {
    return this.isAuthenticated.asObservable();
  }
}
