import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryAService {

  private _url: string = environment.gatewayUrl+'categorya';

  constructor(private http: HttpClient) { }

  getAll() : Observable<CategoryA[]>{
    return this.http.get<CategoryA[]>(this._url).pipe(
      map(res => (res as CategoryA[]))
    )
  }
  getById(id:string): Observable<CategoryA>{
    return this,this.http.get<CategoryA>(this._url+'/'+id).pipe(
      map(res => res as CategoryA)
    )
  }

}
