import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataSharingService } from '../../services/data-sharing.service';
import { FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-forgot-user',
  templateUrl: './forgot-user.component.html',
  styleUrls: ['./forgot-user.component.css']
})
export class ForgotUserComponent implements OnInit {
  passwordUpdateForm: FormGroup;
  forgotEmail: string | null = '';

  constructor(
    private http: HttpClient,
    private dataSharingService: DataSharingService,
    private formBuilder: FormBuilder,
    private router: Router,
    private toastr:ToastrService
  ) {
    this.passwordUpdateForm = this.formBuilder.group({
      password: ['', [Validators.required, Validators.pattern(/^(?=.*\d)(?=.*[a-zA-Z]).{8,}$/)]],
      confirmPassword: ['', Validators.required]
    }, { validators: this.passwordsMatchValidator });
  }

  ngOnInit() {
    this.forgotEmail = localStorage.getItem('resetemail');
   
  }

  updatePassword() {
    console.log(this.forgotEmail);
    if (!this.forgotEmail) {
      this.toastr.error('User Email Not Found');
      return;
    }

    const apiUrl = `https://localhost:7035/api/UserDetails/${encodeURIComponent(this.forgotEmail)}`;

    const updateData = {
      Password: this.passwordUpdateForm.get('password')?.value
    };

    this.http.put(apiUrl, updateData).subscribe(
      (response) => {
        console.log('Password updated successfully', response);
        this.router.navigateByUrl('/login');
        this.toastr.success('Password Changed', 'Success');
      },
      (error) => {
       
        this.toastr.success('Error While changing Password, Link Expired', 'Success');
      }
    );
  }

  passwordsMatchValidator(control: AbstractControl): { [key: string]: boolean } | null {
    const password = control.get('password');
    const confirmPassword = control.get('confirmPassword');

    if (password && confirmPassword && password.value !== confirmPassword.value) {
      return { passwordMismatch: true };
    }

    return null;
  }
}
