import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class CreatorService {

  private url = 'https://localhost:7035/api/Creators';

  constructor(private http: HttpClient) { }

  getcreator(): Observable<any> {
    return this.http.get<any>(this.url);
  }
  GetCreatorById(id:number): Observable<any>
  {
    return this.http.get<any>(`${this.url}/${id}`);
  }
}
