import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrainingDetailsComponent } from './trainingdetails.component';

describe('Button1Component', () => {
  let component: TrainingDetailsComponent;
  let fixture: ComponentFixture<TrainingDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TrainingDetailsComponent]
    });
    fixture = TestBed.createComponent(TrainingDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
