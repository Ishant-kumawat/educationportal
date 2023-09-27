import { Component, OnInit } from '@angular/core';
import { AllService, Course } from '../services/AllService.service';

@Component({
  selector: 'app-component1',
  templateUrl: './component1.component.html',
  styleUrls: ['./component1.component.css']
})
export class Component1Component implements OnInit {
  courses: Course[] = [];

  constructor(private allService: AllService) { }
  
  ngOnInit(): void {
    this.loadCourses();
  }

  loadCourses(): void {
    this.allService.getAllCourses().subscribe(courses => {
      this.courses = courses;
      this.loadCourseImages(); // Call this function to load course images
    });
  } 
  
  loadCourseImages(): void {
    for (const course of this.courses) {
      const imageBlob = this.allService.getDecodedImage(course.image);
      const imageUrl = URL.createObjectURL(imageBlob);
      course.image = imageUrl;
    }
  }
}
