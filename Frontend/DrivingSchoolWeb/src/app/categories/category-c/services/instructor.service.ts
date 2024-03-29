import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {Instructor} from 'src/app/categories/category-c/models/instructor.interface';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {

  private _url: string = environment.gatewayUrl+'categoryc';

  constructor(private http: HttpClient) { }

  getInstructorById(id:string,instructorId:string): Observable<Instructor>{
    return this.http.get<Instructor>(this._url+`/${id}/instructor/${instructorId}`).pipe(
      map(res => res as Instructor)
    )
  };

}
