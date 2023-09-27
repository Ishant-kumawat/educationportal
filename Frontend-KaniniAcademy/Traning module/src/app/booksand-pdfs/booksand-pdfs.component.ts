import { Component } from '@angular/core';
import { AllService, Creator, freeResource } from '../services/AllService.service';
@Component({
  selector: 'app-booksand-pdfs',
  templateUrl: './booksand-pdfs.component.html',
  styleUrls: ['./booksand-pdfs.component.css']
})
export class BooksandPdfsComponent {
   freeResources: freeResource[] = [];
     creators: Creator[] = [];
  p: number = 1;
  itemsPerPage: number = 9;
  totalProduct: any;
  filteredResources: freeResource[] = [];

  constructor(private allService: AllService) {}

  ngOnInit(): void {
    this.loadCourses();
       this.loadCreator(); 
  }
  loadCreator(): void {
  this.allService.getCreator().subscribe(creators => {
    this.creators = creators;
    this.loadResourceCreatorNames();
  });
}

loadResourceCreatorNames(): void {
  for (const resource of this.freeResources) {
    const creator = this.creators.find(c => c.creatorId === resource.creatorId);
    if (creator) {
      resource.creatorName = creator.creatorName;
    }
  }
}

  loadCourses(): void {
    this.allService.getFreeResource().subscribe((freeResources) => {
      this.freeResources = freeResources;
      this.loadCourseImages();
         this.loadResourceCreatorNames();
      this.filteredResources = this.freeResources.filter(resource => resource.category === 'Books');
      
      this.totalProduct = this.filteredResources.length;
    });
  }

  loadCourseImages(): void {
    for (const freeResource of this.freeResources) {
      const imageBlob = this.allService.getDecodedImage(freeResource.thumbnail);
      const imageUrl = URL.createObjectURL(imageBlob);
      freeResource.thumbnail = imageUrl;
    }
  }

}
