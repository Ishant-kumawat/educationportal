import { Component, OnInit } from '@angular/core';
import { Review } from '../app.module';
import { MatDialog } from '@angular/material/dialog';
import { NotesPopupComponent } from '../notespopup/notespopup.component';
import { ImageConverterService } from '../service/image-converter.service';
import { CreatorService } from '../service/creator.service';
import { TrainingService } from '../service/training.service';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';



@Component({
  selector: 'app-trainingdetails',
  templateUrl: './trainingdetails.component.html',
  styleUrls: ['./trainingdetails.component.css']
})
export class TrainingDetailsComponent implements OnInit {

  usability: any = { id: '', description: '' };
  review: any[] = [];
  training: any[] = [];
  textareaData: any = { work: '' };
  creator: any[] = [];
  creatordetails: any={};
  notes: any[] = [];
  Addnotes: any = { category: null, description: '' }

  userId:string|null=''
  trainingId: string | null = ''
  creatorId: string|null=''
  trainingdetail: any = {}

  trainingDescription:string=''
  trainingwork:string=''

  trainingcreator: any[]=[];

  toastrOptions = {
    closeButton: true,
    timeOut: 5000,
    progressBar: true,
  };

  constructor(private dialog: MatDialog,
    private creatorservice: CreatorService,
    private imageConverterService: ImageConverterService,
    private Service: TrainingService,
    private activatedRoute: ActivatedRoute,
    private toastr : ToastrService,
    private router : Router
    ) { }

  openPopup(): void {
    this.dialog.open(NotesPopupComponent);
  }

  ngOnInit(): void {
    this.userId=localStorage.getItem('userId')
    this.creatorservice.getcreator().subscribe((data) => {
      this.creator = data;
      
    })
    this.Service.getnotes().subscribe((data) => {
      this.notes = data;
    })
    this.Service.getTrainings().subscribe((data) => { 
      this.training = data;
    })
    this.Service.getreview().subscribe((data) => {
      this.review = data;
    })
    const ids = 1;
    this.Service.GetById(ids).subscribe((data) => {
      this.usability = data;
    })
    this.activatedRoute.paramMap.subscribe((param) => {
      this.trainingId = param.get("id")
    }, (error) => {
      console.log(error)
    })
  
  if (this.trainingId != null) {
    this.Service.getTrainingById(parseInt(this.trainingId)).subscribe((data) => {
      this.trainingdetail = data
      this.creatorId=data.creatorId
      localStorage.setItem('creatorId',data.creatorId)
    }, (error) => {
      console.log(error)
    })
  }
  this.creatorId=localStorage.getItem('creatorId')
  if(this.creatorId != null){
    this.creatorservice.GetCreatorById(parseInt(this.creatorId)).subscribe((data) => {
      this.creatordetails = data
      localStorage.removeItem('creatorId')
      this.creatordetails.creatorImage = this.imageConverterService.byteArrayToImageUrl(this.creatordetails.creatorImage);
    })
  }
  }

  ratingcount = 0;
  totalrating = 0;
  Finalrating: any;
  reviews: Review[] =
    [
      { title: 'Description', description: `` },
      { title: 'Review', description: '' },
      {
        title: 'Resources', description: `References & Where to learn More

        Herbert Simon, The Sciences of the Artificial (3rd Edition), 1996:
        https://monoskop.org/images/9/9c/Simon_Herbert_A_The_Sciences_of_the_Artificial_3rd_ed.pdf

        d.school, An Introduction to Design Thinking PROCESS GUIDE, 2010:
        https://s3-eu-west-1.amazonaws.com/ih-materials/uploads/Introduction-to-design-thinking.pdf:

        Gerd Waloszek, Introduction to Design Thinking, 2012
        https://experience.sap.com/skillup/introduction-to-design-thinking/`
      },
      { title: 'Submission', description: '', }
    ];

  selectedReview: Review | null = this.reviews[0];
  openReview(review: Review): void {
    this.selectedReview = review;
  }

  AddSubmission() {
    if(this.userId!=null && this.trainingId!=null){
      var textareaData1: any = { work:this.trainingwork,userId:parseInt(this.userId),trainingId:parseInt(this.trainingId) };
     }

    this.Service.addsubmission(textareaData1).subscribe((data) => {
      this.toastr.success('Submitted', 'Success',this.toastrOptions);

    }, (res) => {
      console.log(res);
    })

  }
  
  addnotes() {
    if(this.userId!=null){
      var Addnotes1: any = { category: null, description: this.trainingDescription,userId:parseInt(this.userId) }
    }
    this.Service.addnotes(Addnotes1).subscribe((data) => {
      this.toastr.success('Notes Added', 'Success', this.toastrOptions);
    }
    ), (response: any) => {
      console.log(response);
    }
  }
  
  isTextareaInvalid = false;

  validateTextarea() {
    this.isTextareaInvalid = this.Addnotes.description.trim() === '';  
  }
  isSaveButtonDisabled(): boolean {
    return this.isTextareaInvalid || this.Addnotes.description.trim() === '';
  }

  TextareaInvalid = false;

  validateText() {
    this.TextareaInvalid = this.textareaData.work.trim() === '';
  }

  isSubmitButton(): boolean {
    return this.TextareaInvalid || this.textareaData.work.trim() === '';
  }
  reviewc(){
    this.router.navigate(['review'])
  }
}
