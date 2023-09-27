import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { TrainingService } from '../service/training.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-notespopup',
  templateUrl:'./notespopup.component.html',
  styleUrls: ['./notespopup.component.css']
 
})
export class NotesPopupComponent implements OnInit{
  usability: any[]=[];
  userId: string|null='';

    Addnotes: any={
      category:null,
      description:'',
    }
    notes:any[]=[]
    

  constructor(
    private service : TrainingService,
    public dialogRef: MatDialogRef<NotesPopupComponent>,
    private toastr : ToastrService
   
  ) {}
  @Inject(MAT_DIALOG_DATA) public data: any
  
  ngOnInit(): void {
    this.userId=localStorage.getItem('userId');
    this.service.getnotes().subscribe((data)=>{
      this.notes=data
    })
    this.service.getUsability().subscribe((data)=>{
      this.usability=data;
    })
  }

  closePopup(): void {
    this.dialogRef.close();
  }
  addnotes(){
    const toastrOptions = {
      closeButton: true,
      timeOut: 5000,
      progressBar: true,
    };
    if(this.userId!=null){
      this.Addnotes.userId=parseInt(this.userId)
    }
    this.service.addnotes(this.Addnotes).subscribe((data)=>{
      console.log("data inserted",data);
      this.toastr.success('Notes Added', 'Success', toastrOptions);

    }
    ),(response:any)=>{
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
}
