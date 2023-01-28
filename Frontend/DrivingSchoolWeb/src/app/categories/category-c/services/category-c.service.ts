import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {CategoryC} from 'src/app/categories/category-c/models/categoryC.interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryCService {

  private _url: string = environment.gatewayUrl+'categoryc';

  constructor(private http: HttpClient) { }

  getAll(): Observable<CategoryC[]>{
    return this.http.get<CategoryC[]>(this._url).pipe(
      map(res => (res as CategoryC[]))
    )
  }
  getById(id:string): Observable<CategoryC>{
    return this.http.get<CategoryC>(this._url+'/'+id).pipe(
      map(res => res as CategoryC)
    )
  }
}
