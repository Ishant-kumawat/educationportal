import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {
  private forgotEmail: string = '';

  setForgotEmail(email: string) {
    this.forgotEmail = email;
 localStorage.setItem('resetemail',this.forgotEmail);
    console.log('Forgot email set:', this.forgotEmail);
  }

  getForgotEmail(): string {
    console.log('Forgot email retrieved:', this.forgotEmail);
    return this.forgotEmail;
  }
}
