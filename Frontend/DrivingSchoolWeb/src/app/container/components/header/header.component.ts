import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import {AuthenticatedService} from 'src/app/shared/services/authenticated.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit, OnDestroy{
  public isAuthenticated: boolean = false;
  private _oidcSubscription: Subscription = new Subscription();
  constructor(private _oidsSecurityService: OidcSecurityService,
              private _authenticatedService: AuthenticatedService) {
  }
  ngOnInit(): void {
    this._oidcSubscription = this._oidsSecurityService.checkAuth().subscribe(({isAuthenticated,userData})=> {
      console.log(userData);
      console.log('is authenticated from header ', isAuthenticated)
      this.isAuthenticated = isAuthenticated;
      this._authenticatedService.isAuthenticated(isAuthenticated);
    });
  }
  logIn(): void{
    this._oidsSecurityService.authorize();
  }
  logOut(): void{
    this._oidsSecurityService.logoff().subscribe(res => console.log('log out ', res));
  }
  ngOnDestroy(): void {
    this._oidcSubscription.unsubscribe();
  }
}
