import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {Instructor} from 'src/app/categories/category-b/models/instructor.interface';
import {ResponseError} from 'src/app/shared/models/response-error.interface';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {

  private url: string = environment.gatewayUrl+'categoryb';

  constructor(private http: HttpClient) { }

  getInstructorById(id:string,instructorId:string): Observable<Instructor>{
    return this.http.get<Instructor>(this.url+`/${id}/instructor/${instructorId}`).pipe(
      map(res => res as Instructor)
    )
  }
}
