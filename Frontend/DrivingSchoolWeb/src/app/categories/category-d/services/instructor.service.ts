import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map,tap} from 'rxjs/operators';
import {Instructor} from 'src/app/categories/category-d/models/instructor.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {

  private uri:string = "https://localhost:7206/api/categoryd";

  constructor(private http: HttpClient) { }

  getInstructorById(id:string,instructorId:string): Observable<Instructor>{
    return this.http.get<Instructor>(this.uri+`/${id}/instructor/${instructorId}`).pipe(
      map(res => res as Instructor)
    )
  }

}
