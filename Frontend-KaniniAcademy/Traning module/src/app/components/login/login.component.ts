import { Router } from '@angular/router';
import { Component, OnInit,HostBinding } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import ValidateForm from '../../helpers/validationform';
import { UserService } from '../../services/user.service';
import { DataSharingService } from '../../services/data-sharing.service';
import emailjs, { EmailJSResponseStatus } from '@emailjs/browser';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
  
})
export class LoginComponent implements OnInit {
  public loginForm!: FormGroup;
  type: string = 'password';
  isText: boolean = false;
  eyeIcon: string = 'fa-eye-slash';
  constructor(
    private formdata: FormBuilder,
    private router: Router,
    private userService:UserService,
    private dataSharingService: DataSharingService,
    private toastr:ToastrService
  ) {}
  forgotEmail: string = '';
  userData: any; 
  ngOnInit() {
    this.loginForm = this.formdata.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
    this.startCarousel();
  }

  forgotPasswordModalVisible = false;

  openForgotPasswordModal() {
    this.forgotPasswordModalVisible = true;
  }

  closeForgotPasswordModal() {
    this.forgotPasswordModalVisible = false;
  }
  
  toggleForgotPasswordModal() {
    this.forgotPasswordModalVisible = !this.forgotPasswordModalVisible;
  }

  public sendEmail(data:any) {
    emailjs.send('service_dikshant', 'template_user',data, 'M0XsdAZnMPbHU8c9-')
      .then((result: EmailJSResponseStatus) => {
        console.log(result.text);
      }, (error) => {
        console.log(error.text);
      });
  }



  sendResetLink() {
    const ForgotEmail = this.forgotEmail; 
    this.dataSharingService.setForgotEmail(this.forgotEmail);
   
    let dataForforgotPass:any={
        email:this.forgotEmail,
        link:`http://localhost:4200/forgot-user`
    }
    this.userService.getUserByEmail(this.forgotEmail).subscribe(
      (response) => {
        this.userData = response; 
        this.sendEmail(dataForforgotPass)
        console.log(this.userData);
        this.toastr.success('User Found', 'Success');
      },
      (error) => {
        this.toastr.error('User Not Found', 'Error');
      }
    );
  }
  

  @HostBinding('@modalState')
  get modalState() {
    return this.forgotPasswordModalVisible ? 'visible' : 'hidden';
  }
  
  hideShowPass() {
    this.isText = !this.isText;
    this.isText ? (this.eyeIcon = 'fa-eye') : (this.eyeIcon = 'fa-eye-slash');
    this.isText ? (this.type = 'text') : (this.type = 'password');
  }
  
   onSubmit() {
    if (this.loginForm.valid) {
      const loginData = {
        username: this.loginForm.value.username,
        password: this.loginForm.value.password
      };

      this.userService.authenticateUser(this.loginForm.value).subscribe({
        next: (res) => {
          const userDetails =  res.user;
          this.loginForm.reset();
          localStorage.setItem('token',res.token)
          localStorage.setItem('userId',res.user.userId)
          this.router.navigateByUrl('/Home'); 
          this.toastr.success('Logged In', 'Success');
        },
        error: (err) => {
          this.toastr.error('User Not Exist', 'Error');
          console.log(err);
        }
      });
    } else {
      ValidateForm.validateAllFormFields(this.loginForm);
    }
  }


  imagelogo = 'assets/images/';
  imageUrl = 'assets/images/';
  currentIndex = 0;
  activeForm: 'login' | 'signup' = 'login';
  carouselTexts: { title: string, description: string }[] = [
    {
      title: 'Kanini News',
      description: 'Kanini News Gives You The Latest Tech News'
    },
    {
      title: 'Kanini Community',
      description: 'Kanini Community Gives you communicate your seniors'
    },
    {
      title: 'Kanini Education',
      description: 'Kanini Education, Best For Interns Career Growth'
    }
  ];

  toggleForm(form: 'login' | 'signup'): void {
    this.activeForm = form;
  }

  isActive(index: number): boolean {
    return index === this.currentIndex;
  }

  startCarousel(): void {
    setInterval(() => {
      this.currentIndex++;
      if (this.currentIndex === this.carouselTexts.length) {
        this.currentIndex = 0;
      }
    }, 2000);
  }

  getCurrentText(): { title: string, description: string } {
    return this.carouselTexts[this.currentIndex];
  }
  
  goToSlide(index: number): void {
    this.currentIndex = index;
  }


}
