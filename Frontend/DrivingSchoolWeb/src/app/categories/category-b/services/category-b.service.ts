import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap} from 'rxjs/operators';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB';
import {ResponseError} from 'src/app/shared/models/response-error';

@Injectable({
  providedIn: 'root'
})
export class CategoryBService {
  private uri:string = "https://localhost:7192/api/categoryb";
  constructor(private http: HttpClient) { }

  getAll(): Observable<CategoryB[]>{
    return this.http.get<CategoryB[]>(this.uri).pipe(
      tap(res => console.log('from category b service',res)),
      map(res => (res as CategoryB[]))
    )
  }
}
