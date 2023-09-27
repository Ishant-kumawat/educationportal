import { Component, OnInit } from '@angular/core';
import { TrainingService } from '../service/training.service';


@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.css']
})
export class ReviewComponent implements OnInit {
  review: any[] = [];

  constructor(    
    private Service: TrainingService,
    ){}

  ngOnInit(): void {
    this.Service.getreview().subscribe((data) => {
      this.review = data;
    })
  }

}
