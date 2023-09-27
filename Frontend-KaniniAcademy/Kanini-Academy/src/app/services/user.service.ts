import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = 'http://localhost:5239/api'; // Replace with your API endpoint URL

  constructor(private http: HttpClient) {}

  signUp(user: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/UserDetails`, user);
  }
  authenticateUser(credentials: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/Token`, credentials);
  }
}
