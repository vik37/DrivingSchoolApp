import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject, of } from 'rxjs'
import { tap,concatMap,finalize } from 'rxjs/operators';

@Injectable({providedIn:'root'})
export class LoadingService {

  private _loadingSubject = new BehaviorSubject<boolean>(false);
  public loading$  = this._loadingSubject.asObservable();

  constructor() { }

  showLoaderUntilCompleted<T>(obs$: Observable<T>): Observable<T>{
      return of(null).pipe(
                tap(() => this.loadingOn()),
                concatMap(() => obs$),
                finalize(() => this.loadingOff())
              )
  }
  loadingOn(){
    this._loadingSubject.next(true);
  }
  loadingOff(){
    this._loadingSubject.next(false);
  }
}
