import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryCService {
  //private uri:string = "https://localhost:8080/api/categoryc";
  private url: string = environment.gatewayUrl+'categoryc';
  constructor(private http: HttpClient) { }

  getAll(): Observable<CategoryC[]>{
    return this.http.get<CategoryC[]>(this.url).pipe(
      map(res => (res as CategoryC[]))
    )
  }
  getById(id:string): Observable<CategoryC>{
    return this.http.get<CategoryC>(this.url+'/'+id).pipe(
      map(res => res as CategoryC)
    )
  }
}
