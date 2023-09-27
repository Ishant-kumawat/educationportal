import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


export interface certificate{
  cid: number,
  cname:string,
  keySkills:string,
  duration : string,
  projects : string,
  videosDuration : string,
  certificatePass : string,
  trainingFormat : string
}

@Injectable({
  providedIn: 'root'
})

export class CertserviceService {

  private baseUrl = 'https://localhost:7035/api/Certificate';

  constructor( private http: HttpClient) { }

  getCertificates(): Observable<any>{
    return this.http.get<any>(this.baseUrl)
       
  }
  getCertificateId(id :number): Observable<any>{
  let baseUrl1= `https://localhost:7035/api/Certificate/${id}`
  return this.http.get<any>(baseUrl1)
}

}