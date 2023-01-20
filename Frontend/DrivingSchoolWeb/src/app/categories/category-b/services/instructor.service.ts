import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map,tap } from 'rxjs/operators';
import {Instructor} from 'src/app/categories/category-b/models/instructor';
import {ResponseError} from 'src/app/shared/models/response-error';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {
  private uri:string = "https://localhost:7192/api/categoryb";
  constructor(private http: HttpClient) { }

  getInstructorById(id:string,instructorId:string): Observable<Instructor>{
    return this.http.get<Instructor>(this.uri+`/${id}/instructor/${instructorId}`).pipe(
      tap(res => console.log(res)),
      map(res => res as Instructor)
    )
  }
}
