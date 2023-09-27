import { Component } from '@angular/core';

@Component({
  selector: 'app-trending-blog',
  templateUrl: './trending-blog.component.html',
  styleUrls: ['./trending-blog.component.css']
})
export class TrendingBlogComponent {
  
  Treblog_card_data : any[] = [
    {
      label : "Tech Stack",
      TreblogImage : '../../assets/images/TR1.svg',
    },
    {
      label : "Psycology",
      TreblogImage : '../../assets/images/TR2.svg',
    },
    {
      label : "Business",
      TreblogImage : '../../assets/images/TR3.svg',
    },
    {
      label : "Productivity",
      TreblogImage : '../../assets/images/TR4.svg',
    }
   
   
  ]

}
