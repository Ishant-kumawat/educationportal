import { Component } from '@angular/core';

@Component({
  selector: 'app-freeresource-navbar',
  templateUrl: './freeresource-navbar.component.html',
  styleUrls: ['./freeresource-navbar.component.css']
})
export class FreeresourceNavbarComponent {
 selectedComponent: string = 'resource-navbar'; // Default value

  // Update the selectedComponent based on your logic, such as user interactions
  changeComponent(component: string) {
    this.selectedComponent = component;
}
}
