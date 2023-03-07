import { Injectable } from '@angular/core';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  tokenRequest!: HttpRequest<unknown>;
  isAuthenticate: boolean = false;

  constructor(private _oidcSecurityService: OidcSecurityService) {}


  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    this._oidcSecurityService.getAccessToken().subscribe(token => {
      console.log('auth interceptor - token: ', token);
      if(token){
        this.isAuthenticate = true;
        this.tokenRequest  = request.clone({
          headers: request.headers.set("Authorization", "Bearer "+token)
        })
      }
    })
    return this.isAuthenticate?next.handle(this.tokenRequest):next.handle(request);
  }
}
