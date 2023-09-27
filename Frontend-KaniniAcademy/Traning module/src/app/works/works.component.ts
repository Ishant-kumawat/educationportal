import { Component } from '@angular/core';
import { DetailcertService } from '../service/detailcert.service';

@Component({
  selector: 'app-works',
  templateUrl: './works.component.html',
  styleUrls: ['./works.component.css']
})
export class WorksComponent {

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
