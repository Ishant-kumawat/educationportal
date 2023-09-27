import { Component } from '@angular/core';
import { DetailcertService } from '../service/detailcert.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent {

  details: any[]=[];

  constructor(
    private detailcert:DetailcertService,
    
  ){}

  ngOnInit():void{
    this.detailcert.getdetailedcertificate().subscribe((data)=>{
      this.details = data
    })
  }

}
