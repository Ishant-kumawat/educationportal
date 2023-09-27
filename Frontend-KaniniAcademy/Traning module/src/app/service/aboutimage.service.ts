import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface aboutimage{
  imageId:number,
  shareCert:string,
  onlinecour:string,
  schedule:string,
  level:string,
  approtime:string,
  language:string
}

@Injectable({
  providedIn: 'root'
})
export class AboutimageService {

  private baseUrl = 'http://localhost:5239/api/AboutCertificate';

  constructor( private http: HttpClient) { }

  getAboutthecerti():Observable<any>{
    return this.http.get<any>(this.baseUrl);
  }
}
