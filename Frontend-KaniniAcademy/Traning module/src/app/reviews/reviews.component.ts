import { Component, OnInit } from '@angular/core';
import { TrainingService } from '../service/training.service';// Import your service
 import {Reviews} from '../service/traning.model';// Import your interface

@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.css']
})
export class ReviewsComponent implements OnInit {
  reviews: Reviews[] = [];

  constructor(private reviewService: TrainingService) { }

  ngOnInit(): void {
    this.getReviews();
  }

  getReviews(): void {
    this.reviewService.getreview().subscribe(
      (data: Reviews[]) => {
        this.reviews = data;
      },
      (error) => {
        console.error('Error fetching reviews:', error);
      }
    );
  }
}
