import { Component } from '@angular/core';

@Component({
  selector: 'app-viewcoursenavbar',
  templateUrl: './viewcoursenavbar.component.html',
  styleUrls: ['./viewcoursenavbar.component.css']
})
export class ViewcoursenavbarComponent {
  selectedComponent: string = 'component1'; // Default value

  // Update the selectedComponent based on your logic, such as user interactions
  changeComponent(component: string) {
    this.selectedComponent = component;
}
}
