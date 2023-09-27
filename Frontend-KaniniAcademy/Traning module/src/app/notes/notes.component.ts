import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.css']
})
export class NotesComponent {
  constructor(private router: Router) {}

  viewAllNotes() {
    this.router.navigateByUrl('/viewallnotes');
  }
}
