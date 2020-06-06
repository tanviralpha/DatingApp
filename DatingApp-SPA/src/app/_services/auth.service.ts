import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  // add variable

  baseUrl =  'http://localhost:5000/api/auth/';

constructor(private http: HttpClient) { }

// http post implementaion for the api using the model coming from nav
login(model: any){
  return this.http.post(this.baseUrl + 'login', model)
  .pipe(
    map((response: any) => {
      const user = response;
      if (user) {
        localStorage.setItem('token', user.token);
      }
    })
  );
}

register(model: any){
  return this.http.post(this.baseUrl + 'register', model);
}

}
