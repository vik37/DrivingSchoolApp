import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {CategoryD} from 'src/app/categories/category-d/models/categoryD.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryDService {
  //private uri: string = "https://localhost:7213/gateway/categoryd";
  private url: string = environment.gatewayUrl+'categoryd';
  constructor(private http: HttpClient) { }

  getAll(): Observable<CategoryD[]>{
    return this.http.get<CategoryD[]>(this.url).pipe(
      map(res => (res as CategoryD[]))
    )
  }
  getById(id:string): Observable<CategoryD>{
    return this.http.get<CategoryD>(this.url+'/'+id).pipe(
      map(res => res as CategoryD)
    )
  }
}
