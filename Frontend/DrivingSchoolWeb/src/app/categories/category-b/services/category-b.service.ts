import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {CategoryB} from 'src/app/categories/category-b/models/categoryB.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryBService {

  private url: string = environment.gatewayUrl+'categoryb';

  constructor(private http: HttpClient) { }

  getAll(): Observable<CategoryB[]>{
    return this.http.get<CategoryB[]>(this.url).pipe(
      map(res => (res as CategoryB[]))
    )
  }
  getById(id:string): Observable<CategoryB>{
    return this.http.get<CategoryB>(this.url+'/'+id).pipe(
      map(res => res as CategoryB)
    )
  }
  
}
