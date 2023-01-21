import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap,shareReplay, switchMap} from 'rxjs/operators';
import {CategoryA} from 'src/app/categories/category-a/models/categoryA.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryAService {
  private uri:string = "https://localhost:7149/api/categorya";
  constructor(private http: HttpClient) { }

  getAll() : Observable<CategoryA[]>{
    return this.http.get<CategoryA[]>(this.uri).pipe(
      map(res => (res as CategoryA[]))
    )
  }
  getById(id:string): Observable<CategoryA>{
    return this,this.http.get<CategoryA>(this.uri+'/'+id).pipe(
      map(res => res as CategoryA)
    )
  }
}
