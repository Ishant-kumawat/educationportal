import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import ValidateForm from '../../helpers/validationform';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})

export class SignupComponent implements OnInit {

  public signUpForm!: FormGroup;
  type: string = 'password';
  isText: boolean = false;
  eyeIcon:string = "fa-eye-slash"
  constructor(private fb : FormBuilder,  private router: Router, private userService: UserService ) { }

  ngOnInit() {
    this.signUpForm = this.fb.group({
      firstName:['', Validators.required],
      lastName:['', Validators.required],
      userName:['', Validators.required],
      email:['', Validators.required],
      password:['', Validators.required]
    })
    this.startCarousel();
  }

  hideShowPass(){
    this.isText = !this.isText;
    this.isText ? this.eyeIcon = 'fa-eye' : this.eyeIcon = 'fa-eye-slash'
    this.isText ? this.type = 'text' : this.type = 'password'
  }

  onSubmit() {
    if (this.signUpForm.valid) {
      const signUpObj = {
        ...this.signUpForm.value,
       
      };
  
      // Call the signUp method from the UserService
      this.userService.signUp(signUpObj).subscribe({
        next: (res) => {
          this.signUpForm.reset();
          console.log(res.message);
          this.router.navigate(['/login']);
        },
        error: (err) => {
          window.alert(err?.error.message);
          
        }
      });
    } else {
      // Assuming ValidateForm.validateAllFormFields() is defined elsewhere
      ValidateForm.validateAllFormFields(this.signUpForm);
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
