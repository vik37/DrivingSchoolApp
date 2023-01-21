import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map,tap} from 'rxjs/operators';
import {Instructor} from 'src/app/categories/category-c/models/instructor.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {
  private uri:string = "https://localhost:7275/api/categoryc";
  constructor(private http: HttpClient) { }

  getInstructorById(id:string,instructorId:string): Observable<Instructor>{
    return this.http.get<Instructor>(this.uri+`/${id}/instructor/${instructorId}`).pipe(
      tap(res => console.log(res)),
      map(res => res as Instructor)
    )
  }
}
