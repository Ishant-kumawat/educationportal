import { Component } from '@angular/core';
import { AllService,freeResource, Creator} from '../services/AllService.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-all',
  templateUrl: './all.component.html',
  styleUrls: ['./all.component.css']
})
export class AllComponent {
  freeResources: freeResource[] = [];
  creators: Creator[] = [];
  p: number = 1;
  itemsPerPage: number = 9;
  totalProduct: any;
  filteredResources: freeResource[] = [];

  constructor(private allService: AllService,private router: Router) {}

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
    this.allService.getFreeResource().subscribe(freeResources => {
      this.freeResources = freeResources;
      this.loadBlogImages();
      this.loadResourceCreatorNames();
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
   goToDownloadPage(creatorId: number): void {
    this.router.navigate(['/downloadpage', creatorId]);
  }
  
}