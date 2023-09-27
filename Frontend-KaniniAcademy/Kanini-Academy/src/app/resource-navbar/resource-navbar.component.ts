import { Component } from '@angular/core';

@Component({
  selector: 'app-resource-navbar',
  templateUrl: './resource-navbar.component.html',
  styleUrls: ['./resource-navbar.component.css']
})
export class ResourceNavbarComponent {
   selectedComponent: string = 'resource-navbar'; // Default value

  // Update the selectedComponent based on your logic, such as user interactions
  changeComponent(component: string) {
    this.selectedComponent = component;
}
}
