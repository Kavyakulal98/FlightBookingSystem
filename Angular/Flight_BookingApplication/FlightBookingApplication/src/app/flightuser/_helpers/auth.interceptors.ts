
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpHandler, HttpRequest } from '@angular/common/http';
import { TokenStorageService } from 'src/app/service/token-storage.service';

const TOKEN_HEADER_KEY = 'Authorization';
// const TOKEN_HEADER_KEY = 'x-access-token';
@Injectable()
export class AuthInterceptor implements HttpInterceptor {
constructor(private token: TokenStorageService) { }
  intercept(req: HttpRequest<any>, next: HttpHandler) {
      debugger;
    let authReq = req;
    const token = this.token.getToken();
    if (token != null) {
        debugger;
      authReq = req.clone({ headers: req.headers.set(TOKEN_HEADER_KEY, 'Bearer ' + token) });
    }
    return next.handle(authReq);
  }
}
export const authInterceptorProviders = [
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true }
  ];