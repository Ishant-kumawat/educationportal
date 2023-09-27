import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BlogcardComponent } from './blogcard.component';

describe('BlogcardComponent', () => {
  let component: BlogcardComponent;
  let fixture: ComponentFixture<BlogcardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BlogcardComponent]
    });
    fixture = TestBed.createComponent(BlogcardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
