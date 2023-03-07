import { Injectable } from '@angular/core';
import {BehaviorSubject, Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthenticatedService {
  private _isAuthenticatedSubject: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  public isAuthenticated$: Observable<boolean> = this._isAuthenticatedSubject.asObservable();
  constructor() { }

  isAuthenticated(isAuthenticated: boolean): void{
    this._isAuthenticatedSubject.next(isAuthenticated);
  }
}
