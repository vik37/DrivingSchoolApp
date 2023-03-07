import { HTTP_INTERCEPTORS } from "@angular/common/http";
import {ErrorInterceptor} from 'src/app/interceptors/http-error.interceptor';
import { AuthInterceptor } from 'src/app/interceptors/auth.interceptor';

export const interceptorProviders = [
  {provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true},
  {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true}
];
