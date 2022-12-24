import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap} from 'rxjs/operators';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD';
import {ResponseError} from 'src/app/shared/models/response-error';

@Injectable({
  providedIn: 'root'
})
export class CategoryDService {
  private uri: string = "https://localhost:7206/api/categoryd";
  constructor(private http: HttpClient) { }

  get(): Observable<CategoryD[]>{
    return this.http.get<CategoryD[]>(this.uri).pipe(
      tap(res => console.log('from category d service',res)),
      map(res => (res as CategoryD[]))
    )
  }
}