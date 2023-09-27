import { Component, OnInit} from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-trainingand-certificates',
  templateUrl: './trainingand-certificates.component.html',
  styleUrls: ['./trainingand-certificates.component.css']
})
export class TrainingandCertificatesComponent implements OnInit{
  selectedOption: string = 'Development';

  constructor(private router : Router){}

  selectOption(option: string): void {
    this.selectedOption = option;
  }
  ngOnInit(): void {
    
  }

  Certificates(){
    this.router.navigate(['certificate'], );
  }

}
