import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map,tap} from 'rxjs/operators';

@Injectable()
export class PhotoService {
  public uri:string = "https://localhost:7181/api/image/";
  constructor(private http: HttpClient) { }
}

