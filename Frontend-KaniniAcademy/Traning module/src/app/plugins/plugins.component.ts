import { Component } from '@angular/core';
import { AllService ,freeResource, Creator} from '../services/AllService.service';
@Component({
  selector: 'app-plugins',
  templateUrl: './plugins.component.html',
  styleUrls: ['./plugins.component.css']
})
export class PluginsComponent {
   freeResources: freeResource[] = [];
  p: number = 1;
     creators: Creator[] = [];
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
    
    // Fetch creator details for each freeResource
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
    this.allService.getFreeResource().subscribe(freeResources => {
      this.freeResources = freeResources;
      this.loadCourseImages();
        this.loadResourceCreatorNames();

      // Filter the resources based on the category 'Books'
      this.filteredResources = this.freeResources.filter(resource => resource.category === 'Plugins');
      
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


