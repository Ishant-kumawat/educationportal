import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
export interface Course {
  courseId: number;
  courseName: string;
  image: string;
  createdBy: number;
  rating: number;
  courseProvider:string
}
export interface blog{
  topic:string,
  dateOfUpload:Date,
  description:string,
  blogCategory:string,
  createdBy:string

}
@Injectable({
  providedIn: 'root'
})
export class ProjectservicesService {

  private baseUrl = 'http://localhost:5239/api/Course';
  constructor(private http: HttpClient) { }
  getAllCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.baseUrl);
  }

getAllblogs(): Observable<any> {
  return this.http.get('http://localhost:5239/api/Blogs');
}
}
