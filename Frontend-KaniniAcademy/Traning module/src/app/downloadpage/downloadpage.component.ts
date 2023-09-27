import { Component, OnInit } from '@angular/core';
import { AllService, Creator, freeResource } from '../services/AllService.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-downloadpage',
  templateUrl: './downloadpage.component.html',
  styleUrls: ['./downloadpage.component.css']
})
export class DownloadpageComponent implements OnInit {
  freeResources: freeResource[] = [];
  creator: Creator[] = [];
  freeResource: freeResource | null = null;
    imageData:string=''

  constructor(private allService: AllService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.loadCourses();
    this.route.params.subscribe(params => {
      const creatorId = +params['creatorId'];
      this.loadCreator(creatorId);
    });
    this.route.params.subscribe(params => {
      const freeRid = +params['freeRid'];
      this.loadFreeResource(freeRid);
    });
  }

 loadCourses(): void {
  this.allService.getFreeResource().subscribe(freeResources => {
    this.freeResources = freeResources;
    this.loadBlogImages1();
    this.loadResourceCreatorNames();
    console.log('Free Resources:', this.freeResources); 
  });
}


  loadResourceCreatorNames(): void {
    for (const resource of this.freeResources) {
      const creator = this.creator.find(c => c.creatorId === resource.creatorId);
      if (creator) {
        resource.creatorName = creator.creatorName;
      }
    }
  }
  


  loadCreator(creatorId: number): void {
    this.allService.getCreatorById(creatorId).subscribe(creator => {
      this.creator = creator;
      this.loadBlogImages();
      this.loadResourceCreatorNames(); // Load creator names once
    });
  }

  loadBlogImages(): void {
    for (const creator of this.creator) {
      const imageBase64 = creator.creatorImage;
      creator.creatorImage = `data:image/jpeg;base64,${imageBase64}`;
    }
  }

  loadBlogImages1(): void {
    for (const freeResource of this.freeResources) {
      const imageBase64 = freeResource.thumbnail;
      freeResource.thumbnail = `data:image/jpeg;base64,${imageBase64}`;
    }
  }

  loadFreeResource(freeRid: number): void {
  this.allService.getFreeResourceById(freeRid).subscribe(resource => {
    this.freeResource = resource; 
    this. loadResourceCreatorNames()
    const imageBase64 = this.freeResource?.thumbnail;
    if (imageBase64) {
      this.imageData = `data:image/jpeg;base64,${imageBase64}`;
    } else {
      console.log('Image data not available');
    }
  });
}
}
