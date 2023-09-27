import { Component } from '@angular/core';
import { CctableofcontentsComponent } from '../cctableofcontents/cctableofcontents.component';

@Component({
  selector: 'app-continue2',
  templateUrl: './continue2.component.html',
  styleUrls: ['./continue2.component.css']
})
export class Continue2Component {
  activeButton:string='';
  changeColor(button:string)
  {
      this.activeButton=button;
  }
}
