import { Component } from '@angular/core';
import { ImageConverterService } from '../service/image-converter.service';
import { Router } from '@angular/router';
import { CertserviceService } from '../service/certservice.service';

@Component({
  selector: 'app-certificate',
  templateUrl: './certificate.component.html',
  styleUrls: ['./certificate.component.css']
})
export class CertificateComponent  {
  certificates: any[]=[];

  constructor(
    private certservice: CertserviceService,
    private imageConverterService: ImageConverterService,
    private router: Router,
    
  ){ }


  ngOnInit():void {
    this.certservice.getCertificates().subscribe((data)=>{
      this.certificates = data
      console.log("Hello");
    })
    this.certservice.getCertificates().subscribe((data)=>{
      this.certificates=data;
      this.convertToImageUrlForEachTour();
    })
    }
    convertToImageUrlForEachTour() {
      this.certificates.forEach((c) => {
        if (c.image) {
          c.image = this.imageConverterService.byteArrayToImageUrl(c.image);
        }
      });
    }
    
    Details(cid : number){
      this.router.navigate([`/details/${cid}`]);
    }

}
