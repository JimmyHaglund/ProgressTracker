import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {

   private authenticateUrl = environment.apiUrl + "/user";
   private currentUserSubject: any;
   public currentUser: any;

   constructor(private http: HttpClient) {
      let storedCurrentUser = localStorage.getItem('currentUser');
      if (storedCurrentUser != null) {
         let currentUser = new BehaviorSubject<any>(JSON.parse(storedCurrentUser));
         if (currentUser != null) this.currentUserSubject = currentUser;
         this.currentUser = this.currentUserSubject.asObservable();
      }
   }

   public login(userName: string, password: string): Observable<any> {
      console.log("Login attempt: ", userName, ", ", password);
      let login = {userName, password};
      console.log(this.authenticateUrl);
      console.log(login);
      return this.http.post<string>(`${this.authenticateUrl}`, { userName, password })
         .pipe(map(user => {
            console.log(user);
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
         }));
   }
}
