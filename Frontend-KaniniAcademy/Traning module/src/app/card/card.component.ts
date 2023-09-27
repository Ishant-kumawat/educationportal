import { Component } from '@angular/core';
@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
  blog_card_data : any[] = [
    {
      label : "Design",
      authorName : 'Cameron Williamson',
      blogImage : '../../assets/images/BlogImage1.svg',
      profileImage : '../../assets/images/PF1.svg'
    },
    {
      label : "Health",
      authorName : 'Cody Fisher',
      blogImage : '../../assets/images/BlogImage2.svg',
      profileImage : '../../assets/images/PF2.svg'
    },
    {
      label : "Illustration",
      authorName : 'Jane Cooper',
      blogImage : '../../assets/images/BlogImage3.svg',
      profileImage : '../../assets/images/PF3.svg'
    },
    {
      label : "Website",
      authorName : 'Floyd Miles',
      blogImage : '../../assets/images/BlogImage4.svg',
      profileImage : '../../assets/images/PF4.svg'
    },
    {
      label : "Design",
      authorName : 'Jenny Wilson',
      blogImage : '../../assets/images/BlogImage5.svg',
      profileImage : '../../assets/images/PF5.svg'
    },
    {
      label : "Health",
      authorName : 'Robert Fox',
      blogImage : '../../assets/images/BlogImage6.svg',
      profileImage : '../../assets/images/PF6.svg'
    },
   
  ]
}