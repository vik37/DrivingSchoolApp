import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class PhotoService {
  public uri:string = "https://localhost:7181/api/image/";
  constructor(private http: HttpClient) { }
}

