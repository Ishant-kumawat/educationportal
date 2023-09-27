import { Component,OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ImageConverterService } from '../service/image-converter.service';
import { TrainingService } from '../service/training.service';


@Component({
  selector: 'app-training',
  templateUrl: './training.component.html',
  styleUrls: ['./training.component.css']
})

export class TrainingComponent implements OnInit {
  training: any[]=[];
  
  constructor(private router: Router,
    private trainingService: TrainingService,
    private imageConverterService: ImageConverterService,
    ) { }

    ngOnInit(): void {
      this.trainingService.getTrainings().subscribe((data)=>{
        this.training=data;
        this.convertToImageUrlForEachTour();
      });
    }

    convertToImageUrlForEachTour() {
      this.training.forEach((t) => {
        if (t.image) {
          t.image = this.imageConverterService.byteArrayToImageUrl(t.image);
        }
      });
    }
    
  startTraining(tid: number) {

    this.router.navigate([`TrainingDetails/${tid}`]);



   }

  Certificates(){
    this.router.navigate(['certificate'], );
  }
}

