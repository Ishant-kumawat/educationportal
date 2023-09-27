import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewcoursenavbarComponent } from './viewcoursenavbar.component';

describe('ViewcoursenavbarComponent', () => {
  let component: ViewcoursenavbarComponent;
  let fixture: ComponentFixture<ViewcoursenavbarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ViewcoursenavbarComponent]
    });
    fixture = TestBed.createComponent(ViewcoursenavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
