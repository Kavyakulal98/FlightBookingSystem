import { Injectable } from '@angular/core';
import { Resgister } from '../resgister';
const TOKEN_KEY = 'auth-token';
const USER_KEY = 'auth-user';
@Injectable({
  providedIn: 'root'
})
export class TokenStorageService {
  user:any;

  constructor() { }
  signOut() {
    window.sessionStorage.clear();
  }
  public saveToken(token: string) {
    debugger
    window.sessionStorage.removeItem(TOKEN_KEY);
    window.sessionStorage.setItem(TOKEN_KEY, token);
  }
  public getToken(): string|null {
    debugger
    return sessionStorage.getItem(TOKEN_KEY);
  }
  public saveUser(user: any) {
    debugger
    window.sessionStorage.removeItem(USER_KEY);
    window.sessionStorage.setItem(USER_KEY, JSON.stringify(user));
  }
  public getUser() {
    const user = sessionStorage.getItem(USER_KEY);
    if(user != null){
      debugger
      return JSON.parse(user);
    }
   }
}
