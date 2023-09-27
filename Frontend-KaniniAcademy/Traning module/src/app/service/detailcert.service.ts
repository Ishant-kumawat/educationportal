import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


export interface detail{
  aboutAns1:string,
  aboutAns2:string,
  aboutAns3:string,
  aboutAns4:string,
  aboutAns5:string,
  aboutAns6:string,
  aboutAns7:string,
  aboutAns8:string,
  aboutAns9:string,
  aboutAns10:string,
  aboutAns11:string,
  work1:string,
  work2:string,
  work3:string,
  workAns1:string,
  workAns2:string,
  workAns3:string,
  faqQues1:string,
  faqQues2:string,
  faqQues3:string,
  faqQues4:string,
  faqQues5:string,
  faqAns1:string,
  faqAns2:string,
  faqAns3:string,
  faqAns4:string,
  faqAns5:string,

}
@Injectable({
  providedIn: 'root'
})
export class DetailcertService {

  private baseUrl = 'http://localhost:5239/api/DetailedCertificate';

  constructor( private http: HttpClient) { }

  getdetailedcertificate():Observable<detail[]>{
    return this.http.get<detail[]>(this.baseUrl);
  }
}
