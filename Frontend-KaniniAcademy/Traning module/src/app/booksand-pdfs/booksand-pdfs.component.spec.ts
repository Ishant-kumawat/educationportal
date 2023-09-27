import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BooksandPdfsComponent } from './booksand-pdfs.component';

describe('BooksandPdfsComponent', () => {
  let component: BooksandPdfsComponent;
  let fixture: ComponentFixture<BooksandPdfsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BooksandPdfsComponent]
    });
    fixture = TestBed.createComponent(BooksandPdfsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
