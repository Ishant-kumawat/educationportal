import { Component } from '@angular/core';
import { DetailcertService } from '../service/detailcert.service';

@Component({
  selector: 'app-faq',
  templateUrl: './faq.component.html',
  styleUrls: ['./faq.component.css']
})
export class FaqComponent {

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
