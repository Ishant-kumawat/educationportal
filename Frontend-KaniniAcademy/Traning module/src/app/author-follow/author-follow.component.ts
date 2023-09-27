import { Component,Input, OnInit } from '@angular/core';
import { ImageConverterService } from '../service/image-converter.service';
import { CreatorService } from '../service/creator.service';

@Component({
  selector: 'app-author-follow',
  templateUrl: './author-follow.component.html',
  styleUrls: ['./author-follow.component.css']
})
export class AuthorFollowComponent implements OnInit{
  @Input() AuthorImageSrc: string = '';
  @Input() authorname: string = '';
  creators:any[]=[];

  constructor(
    private imageConverterService : ImageConverterService,
    private creator : CreatorService
  ){
  }

 

ngOnInit(): void {
  this.creator.getcreator().subscribe(
    (data) => {
      this.creators = data; 
      console.log("blog",this.creators);
      this.convertToImageUrlForEachTour();
    },
    (error) => {
      console.error('Error fetching blogs:', error);
    }
  );
}



convertToImageUrlForEachTour() {
  this.creators.forEach((c) => {
    if (c.creatorImage) {
      c.creatorImage = this.imageConverterService.byteArrayToImageUrl(c.creatorImage);
     
    }
  });
}
}
