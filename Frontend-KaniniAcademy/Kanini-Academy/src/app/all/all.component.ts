import { Component } from '@angular/core';
import { AllService,freeResource } from '../services/AllService.service';
@Component({
  selector: 'app-all',
  templateUrl: './all.component.html',
  styleUrls: ['./all.component.css']
})
export class AllComponent {
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
    this.allService.getFreeResource().subscribe(freeResources => {
      this.freeResources = freeResources;
      this.loadBlogImages();

      // Filter the resources based on the category 'Books'
      this.filteredResources = this.freeResources.filter(resource => resource.category === 'All');
      
      this.totalProduct = this.filteredResources.length;
    });
  }

  loadBlogImages(): void {
    for (const freeResource of this.freeResources) {
      const imageBase64 = freeResource.thumbnail; 
      freeResource.thumbnail = `data:image/jpeg;base64,${imageBase64}`;
    }
  }
  
}