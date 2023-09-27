import { Component, OnInit } from '@angular/core';
import { AllService,blog,Course } from '../services/AllService.service';
import { ImageConverterService } from '../service/image-converter.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent  implements OnInit{
  blogs:blog[]=[];
  courses: Course[] = [];

  constructor(private AllService:AllService,
    private imageConverterService : ImageConverterService){}
  ngOnInit(): void {
    this.loadblog();
    this.loadCourses();

  }
  loadblog(): void {
    this.AllService.getAllblogs().subscribe((blogs: blog[]) => {
      this.blogs = blogs; 
      this.convertToImageUrlForEachTour();
    });
  }
  convertToImageUrlForEachTour() {
    this.blogs.forEach((b) => {
      if (b.image) {
        b.image = this.imageConverterService.byteArrayToImageUrl(b.image);
      }
    });
  }
 
  loadCourses(): void {
    
    this.AllService.getAllCourses().subscribe(courses => {
      this.courses = courses;
     this.loadCourseImages();
      this.loadBlogImages();
    });
  }

  loadCourseImages(): void {
    for (const course of this.courses) {
      const imageBase64 = course.image; 
      course.image = `data:image/jpeg;base64,${imageBase64}`;
    }
  }

  loadBlogImages(): void {
    for (const blog of this.blogs) {
      const imageBase64 = blog.image; 
      blog.image = `data:image/jpeg;base64,${imageBase64}`;
      
    }
  }
  
  
}