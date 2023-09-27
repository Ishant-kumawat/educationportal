import { Component } from '@angular/core';
import { AboutimageService } from '../service/aboutimage.service';
import { ImageConverterService } from '../service/image-converter.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-rightside',
  templateUrl: './rightside.component.html',
  styleUrls: ['./rightside.component.css']
})
export class RightsideComponent {

  aboutimages: any[] =[
    
  ];

  constructor(
    private aboutservice: AboutimageService ,
    private imageConverterService: ImageConverterService,
    private router: Router,
  ){ }

  ngOnInit():void {
    this.aboutservice.getAboutthecerti().subscribe((data)=>{
      this.aboutimages = data
      console.log("Hello");
    })
    this.aboutservice.getAboutthecerti().subscribe((data)=>{
      this.aboutimages=data;
      console.log("images",this.aboutimages)
      this.convertToImageUrlForEachTour();
    })
    }
    convertToImageUrlForEachTour() {
      this.aboutimages.forEach((c) => {
        if (c.image1) {
          c.image1 = this.imageConverterService.byteArrayToImageUrl(c.image1);
        }
        if (c.image2){
          c.image2 =  this.imageConverterService.byteArrayToImageUrl(c.image2);
        }
        if (c.image3){
          c.image3 =  this.imageConverterService.byteArrayToImageUrl(c.image3);
        }
        if (c.image4){
          c.image4 =  this.imageConverterService.byteArrayToImageUrl(c.image4);
        }
        if (c.image5){
          c.image5 =  this.imageConverterService.byteArrayToImageUrl(c.image5);
        }if (c.image6){
          c.image6 =  this.imageConverterService.byteArrayToImageUrl(c.image6);
        }
      })  
    }

}
