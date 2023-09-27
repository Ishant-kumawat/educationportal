import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, Observer } from 'rxjs';
import { Training } from './traning.model';

@Injectable({
  providedIn: 'root'
})
export class TrainingService {

  private baseUrl = 'https://localhost:7035/api/Training';

  private url = 'https://localhost:7035/api/Submission';

  constructor(private http: HttpClient) { }


  getTrainings(): Observable<any> {
    return this.http.get<any>(this.baseUrl);
  }


  getTrainingById(id: number): Observable<any> {
    return this.http.get<any>(`${this.baseUrl}/${id}`);
  }


  addTraining(training: Training): Observable<Training> {
    return this.http.post<Training>(`${this.baseUrl}/api/trainings`, training);
  }

  updateTraining(training: Training): Observable<Training> {
    return this.http.put<Training>(`${this.baseUrl}/api/trainings/${training.Tid}`, training);
  }


  deleteTraining(id: number): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/api/trainings/${id}`);
  }

  addsubmission(data: any): Observable<any> {
    return this.http.post<any>(this.url, data);

  }
  getnotes(): Observable<any> {
    let baseurl1 = "https://localhost:7035/api/Notes";
    return this.http.get<any>(baseurl1);
  }


  addnotes(data: any): Observable<any> {
    let bseurl = "https://localhost:7035/api/Notes";
    return this.http.post<any>(bseurl, data);
  }

  getreview(): Observable<any> {
    let baseUrl2 = "https://localhost:7035/api/Review";
    return this.http.get<any>(baseUrl2);
  }
  getUsability(): Observable<any> {
    let baseUrl4 = "https://localhost:7035/api/Usability";
    return this.http.get<any>(baseUrl4);
  }

  GetById(ids: number): Observable<any> {
    let baseUrl3 = `https://localhost:7035/api/Usability/${ids}`;
    return this.http.get<any>(`${baseUrl3}`);
  }

  Getcreatorbytrainingid(idz : number): Observable<any>{
    let baseUrl5 = `https://localhost:7035/api/Creators/${idz}`
    return this.http.get<any>(`${baseUrl5}`)
  }

}
