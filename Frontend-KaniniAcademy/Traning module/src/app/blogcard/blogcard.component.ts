import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AllService } from '../services/AllService.service';
import { ImageConverterService } from '../service/image-converter.service';
import { CreatorService } from '../service/creator.service';
@Component({
  selector: 'app-blogcard',
  templateUrl: './blogcard.component.html',
  styleUrls: ['./blogcard.component.css']
})
export class BlogcardComponent implements OnInit {
  @Input() blogImageSrc: string = '';
  @Input() profileImageSrc: string = '';
  @Input() label: string = '';
  @Input() author: string = '';
  creatorImage: string='';

  constructor(
    private router: Router,
    private allservice: AllService ,
    private imageConverterService : ImageConverterService,
    private creatorservice : CreatorService
  ) {}

  blogs: any[] = []; 
  creatordetails : any={};

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

  navigate() {
    this.router.navigate(['viewsecond']);
  }
}
