import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
export interface Course {
  courseId: number;
  courseName: string;
  courseProvider:string;
  image: string;
  rating: number;
  creatorId: number;
  
  
}
export interface blog{
  topic:string,
  dateOfUpload:Date,
  description:string,
  blogCategory:string,
  createdBy:string
image:string
}
export interface Creator {
    creatorId:number,
    creatorName: string,
    creatorImage: string,
    description: string,
    creatorJob: string
}
export interface freeResource{
  freeRid:number,
  title: string,
  category: string,
  providedBy: string,
  downloads: number,
  description: string,
  thumbnail: string,
  book: string,
  template: string,
  video: string,
  creatorId:number,
  creatorName: string,
    creatorImage: string,
    // description: string,
    creatorJob: string
}
export interface courseResource{
  courseResourceId :Number ,
  video:string,
  thumbnail:string,
  description:string,
  review:string,
  resources:string
}
@Injectable({
  providedIn: 'root'
})
export class AllService {
  private baseUrl = 'https://localhost:7035/api/Course';
  constructor(private http: HttpClient) { }
  getAllCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.baseUrl);
  } 
  
  





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
    let baseUrl1='http://localhost:5239/api/Blogs'
    return this.http.get<any>(`${baseUrl1}`);

  }
getFreeResource(): Observable<any> {
  return this.http.get(' http://localhost:5239/api/FreeResource');
}

getFreeResourceById(id: number): Observable<any> {
  return this.http.get(`http://localhost:5239/api/FreeResource/${id}`);
}
getCreator(): Observable<any> {
  return this.http.get('https://localhost:7035/api/Creators');
}
  getCreatorById(id: number): Observable<any> {
  return this.http.get(`http://localhost:5239/api/Creators/${id}`);
}

getCourseResources():Observable<any>{
  return this.http.get('https://localhost:7035/api/CourseResource')
}

}

