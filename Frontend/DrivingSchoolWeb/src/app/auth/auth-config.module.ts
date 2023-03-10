import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthModule } from 'angular-auth-oidc-client';
import { AuthInterceptor } from 'angular-auth-oidc-client';
import { environment } from 'src/environments/environment';

@NgModule({
    imports: [AuthModule.forRoot({
        config: {
            authority: environment.identityServerUrls.authorityIISUrl,
            redirectUrl: window.location.origin,
            postLogoutRedirectUri: window.location.origin,
            clientId: 'angular',
            scope: 'openid profile offline_access email grendma', // 'openid profile offline_access ' + your scopes
            responseType: 'code',
            silentRenew: true,
            useRefreshToken: true,
            renewTimeBeforeTokenExpiresInSeconds: 30
        }
    })],
    exports: [AuthModule]
})
export class AuthConfigModule {}
