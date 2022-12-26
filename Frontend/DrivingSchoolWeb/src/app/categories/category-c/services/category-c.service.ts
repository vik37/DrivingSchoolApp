import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap} from 'rxjs/operators';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC';
import {ResponseError} from 'src/app/shared/models/response-error';

@Injectable({
  providedIn: 'root'
})
export class CategoryCService {
  private uri:string = "https://localhost:7275/api/categoryc";
  constructor(private http: HttpClient) { }

  getAll(): Observable<CategoryC[]>{
    return this.http.get<CategoryC[]>(this.uri).pipe(
      tap(res => console.log('from category c service',res)),
      map(res => (res as CategoryC[]))
    )
  }
}
