import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PhotoService {
  uri:string = "https://localhost:7181/api/image/";
  constructor(private http: HttpClient) { }


}
