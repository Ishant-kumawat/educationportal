import { Component,Input } from '@angular/core';
import { AllService } from '../services/AllService.service';
import { ImageConverterService } from '../service/image-converter.service';
import { Router } from '@angular/router';
import { CreatorService } from '../service/creator.service';

@Component({
  selector: 'app-second-popular',
  templateUrl: './second-popular.component.html',
  styleUrls: ['./second-popular.component.css']
})
export class SecondPopularComponent {
  @Input() popularImageSrc: string = '';
  @Input() profileImageSrc: string = '';
  @Input() label: string = '';
  @Input() author: string = '';

  
  constructor(
    private router: Router,
    private allservice: AllService ,
    private imageConverterService : ImageConverterService,
    private creatorservice: CreatorService
  ) {}
  creatordetails:any={}

  creatorImage:string=''
  blogs: any[] = []; 

  ngOnInit(): void {
    this.fetchBlogs(); 
    const id = 1
    this.creatorservice.GetCreatorById(id).subscribe((data) => {
      this.creatordetails = data
      console.log("cc",this.creatordetails)
      this.creatorImage=this.imageConverterService.byteArrayToImageUrl(data.creatorImage);
    })
  }

  fetchBlogs() {
    this.allservice.getAllblogs().subscribe(
      (data) => {
        this.blogs = data; 
        console.log("blog",this.blogs);
        this.convertToImageUrlForEachTour();
      },
      (error) => {
        console.error('Error fetching blogs:', error);
      }
    );
  }
  convertToImageUrlForEachTour() {
    this.blogs.forEach((blog) => {
      if (blog.image) {
        blog.image = this.imageConverterService.byteArrayToImageUrl(blog.image);
      }
    });
  }
}
