import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.css']
})
export class PopupComponent {
  selectedButtons: string[] = [];

  constructor(private router: Router) {} 

  onClickButton(buttonId: string) {
    const index = this.selectedButtons.indexOf(buttonId);
    if (index > -1) {
      this.selectedButtons.splice(index, 1);
    } else {
      this.selectedButtons.push(buttonId);
    }
  }

  onClickContinue() {
    this.router.navigate(['/first-page']);
  }

  isButtonSelected(buttonId: string): boolean {
    return this.selectedButtons.includes(buttonId);
  }
}
