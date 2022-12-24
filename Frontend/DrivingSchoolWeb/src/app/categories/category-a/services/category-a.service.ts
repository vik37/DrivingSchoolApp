import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap} from 'rxjs/operators';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA';
import {ResponseError} from 'src/app/shared/models/response-error';

@Injectable({
  providedIn: 'root'
})
export class CategoryAService {
  private uri:string = "https://localhost:7149/api/categorya"
  constructor(private http: HttpClient) { }

  getAll() : Observable<CategoryA[]>{
    return this.http.get<CategoryA[]>(this.uri).pipe(
      tap(res => console.log('from category A service: ',res)),
      map(res => (res as CategoryA[]))
    )
  }
}
