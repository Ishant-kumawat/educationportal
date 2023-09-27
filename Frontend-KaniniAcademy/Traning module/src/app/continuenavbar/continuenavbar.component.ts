import { Component } from '@angular/core';

@Component({
  selector: 'app-continuenavbar',
  templateUrl: './continuenavbar.component.html',
  styleUrls: ['./continuenavbar.component.css']
})
export class ContinuenavbarComponent {
  selectedComponent: string = 'component1'; // Default value

  // Update the selectedComponent based on your logic, such as user interactions
  changeComponent(component: string) {
    this.selectedComponent = component;
  }
}


