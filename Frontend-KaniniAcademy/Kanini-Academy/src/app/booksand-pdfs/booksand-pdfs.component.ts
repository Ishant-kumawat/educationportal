import { Component } from '@angular/core';
import { AllService, freeResource } from '../services/AllService.service';
@Component({
  selector: 'app-booksand-pdfs',
  templateUrl: './booksand-pdfs.component.html',
  styleUrls: ['./booksand-pdfs.component.css']
})
export class BooksandPdfsComponent {
   freeResources: freeResource[] = [];
  p: number = 1;
  itemsPerPage: number = 9;
  totalProduct: any;
  filteredResources: freeResource[] = [];

  constructor(private allService: AllService) {}

  ngOnInit(): void {
    this.loadCourses();
  }

  loadCourses(): void {
    this.allService.getFreeResource().subscribe((freeResources) => {
      this.freeResources = freeResources;
      this.loadCourseImages();

      // Filter the resources based on the category 'Books'
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
