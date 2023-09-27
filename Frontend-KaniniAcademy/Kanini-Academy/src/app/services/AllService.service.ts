import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
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
image:string
}
export interface freeResource{
  title: string,
  category: string,
  providedBy: string,
  downloads: number,
  description: string,
  thumbnail: string,
  book: string,
  template: string,
  video: string
}
@Injectable({
  providedIn: 'root'
})
export class AllService {
  private baseUrl = 'http://localhost:5239/api/Course';
  constructor(private http: HttpClient) { }
  getAllCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.baseUrl);
  } 
  
  
  
  // getCourseImage(imageUrl: string): Observable<Blob> {
  //   return this.http.get(imageUrl, { responseType: 'blob' });
  // }




  getDecodedImage(imageBase64: string): Blob {
    const byteCharacters = atob(imageBase64);
    const byteNumbers = new Array(byteCharacters.length);
    for (let i = 0; i < byteCharacters.length; i++) {
      byteNumbers[i] = byteCharacters.charCodeAt(i);
    }
    const byteArray = new Uint8Array(byteNumbers);
    return new Blob([byteArray], { type: 'image/jpeg' }); // Adjust the 'type' as needed
  }
  


  
  

getAllblogs(): Observable<any> {
  return this.http.get('http://localhost:5239/api/Blogs  ');
}
getFreeResource(): Observable<any> {
  return this.http.get(' http://localhost:5239/api/FreeResource');
}
}