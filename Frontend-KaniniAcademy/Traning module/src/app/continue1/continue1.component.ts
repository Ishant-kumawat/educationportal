import { Component } from '@angular/core';
import { AllService,Course,Creator } from '../services/AllService.service';



@Component({
  selector: 'app-continue1',
  templateUrl: './continue1.component.html',
  styleUrls: ['./continue1.component.css']
})
export class Continue1Component {
  activeButton:string='';
  course:Course[]=[];
  creator:Creator[]=[];
  changeColor(button:string)
  {
      this.activeButton=button;
  }
  selectedComponent: string = 'component1'; // Default value

  // Update the selectedComponent based on your logic, such as user interactions
  changeComponent(component: string) {
    this.selectedComponent = component;
}
courses: Course[] = [];

  constructor(private allService: AllService) { }
  
  ngOnInit(): void {
    this.loadCourses();
  }

  loadCourses(): void {
    this.allService.getAllCourses().subscribe(courses => {
      this.courses = courses;
       // Call this function to load course images
    });
  } 

  loadCreator(): void {
    this.allService.getCreator().subscribe(creators => {
      this.creator = creators;
       // Call this function to load course images
    });
  } 
}
