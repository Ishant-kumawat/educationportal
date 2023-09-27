import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';
import { CertserviceService } from '../service/certservice.service';
import { ImageConverterService } from '../service/image-converter.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit{
  Certificateid : string | null ='';
  certificatedetail : any={};

  constructor(
    private router: Router,
    private activatedRoute: ActivatedRoute,
    private Service : CertserviceService,
    private imageConverterService: ImageConverterService,

  ){ }
 ngOnInit(): void {
  this.activatedRoute.paramMap.subscribe((param) => {
    this.Certificateid = param.get("id")
  }, (error) => {
    console.log(error)
  })
  if (this.Certificateid != null) {
    this.Service.getCertificateId(parseInt(this.Certificateid)).subscribe((data) => {
      this.certificatedetail = data;
      this.convertImagesToUrls();
    }, (error) => {
      console.log(error)
    })
  }
 }
  Works(){
    this.router.navigate(['about']);
  }

  convertImagesToUrls() {
    if (this.certificatedetail.image) {
      this.certificatedetail.image = this.imageConverterService.byteArrayToImageUrl(this.certificatedetail.image);
    }
  }

}
