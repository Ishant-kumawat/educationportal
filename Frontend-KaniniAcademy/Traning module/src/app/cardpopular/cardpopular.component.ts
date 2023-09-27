import { Component } from '@angular/core';

@Component({
  selector: 'app-cardpopular',
  templateUrl: './cardpopular.component.html',
  styleUrls: ['./cardpopular.component.css']
})
export class CardpopularComponent {
  blog_card_data : any[] = [
    {
      label : "Design",
      authorName : 'Cameron Williamson',
      popularImage : '../../assets/BlogImage1.svg',
      profileImage : '../../assets/images/PF1.svg'
    },
    {
      label : "Health",
      authorName : 'Cody Fisher',
      popularImage : '../../assets/BlogImage2.svg',
      profileImage : '../../assets/images/PF2.svg'
    },
    {
      label : "Illustration",
      authorName : 'Jane Cooper',
      popularImage : '../../assets/BlogImage3.svg',
      profileImage : '../../assets/images/PF3.svg'
    }
   
    
  ]
}
