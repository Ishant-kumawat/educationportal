import { Component } from '@angular/core';

@Component({
  selector: 'app-whotofollow',
  templateUrl: './whotofollow.component.html',
  styleUrls: ['./whotofollow.component.css']
})
export class WhotofollowComponent {
  Follow_card_data : any[] = [
    {
      authorname : 'Jane Cooper',
      profileImage : '../../assets/FP1.svg'
    },
    {
      authorname : 'Wade Warren',
      profileImage : '../../assets/FP2.svg'
    },
    {
      authorname : 'Esther Coward',
      profileImage : '../../assets/FP3.svg'
    }
  ]
}
