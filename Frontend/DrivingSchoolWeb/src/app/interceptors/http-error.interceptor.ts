import { Injectable } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable,catchError,throwError } from 'rxjs';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError(this.handleError)
    );
  }
  handleError(error:HttpErrorResponse){
    console.log('from interceptor', error);
    if(error.status === 400 ||  error.status === 401){
      error.error.message = "This page is not allowed";
    }
    let responseError = {
      message: error.error.message,
      status: error.status,
      success:false
    } as ResponseError;
    return throwError(()=>{
      return responseError;
    });
  }
}
