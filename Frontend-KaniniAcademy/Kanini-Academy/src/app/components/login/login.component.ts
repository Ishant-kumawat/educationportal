import { Router } from '@angular/router';
import { Component, OnInit,HostBinding } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import ValidateForm from '../../helpers/validationform';
import { NgToastService } from 'ng-angular-popup';
import { UserService } from 'src/app/services/user.service';
import { Token } from '@angular/compiler';
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
    private fb: FormBuilder,
    private router: Router,
    private toast: NgToastService, // Adjust this to your actual toast service
    private userService:UserService
  ) {}

  ngOnInit() {
    this.loginForm = this.fb.group({
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
          console.log(userDetails)
          this.router.navigateByUrl('/Home'); 
        },
        error: (err) => {
         window.alert("Invalid Credentials");
          console.log(err);
        }
      });
    } else {
      ValidateForm.validateAllFormFields(this.loginForm);
    }
  }


  imagelogo = 'assets/img/';
  imageUrl = 'assets/img/';
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
