import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/user';
const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {
  constructor(private http: HttpClient) { }
  createUser(user: User): Observable<User> {
    return this.http.post<User>(environment.API, user, httpOptions);
  }
  getAllUsers() {
    return new Promise((resolve, reject) => {
        this.http.get<User[]>(environment.API).subscribe(
          (result: any) => {
            resolve(result);
          },
          error => {
            reject(error);
          }
        );
      });
  }
}
