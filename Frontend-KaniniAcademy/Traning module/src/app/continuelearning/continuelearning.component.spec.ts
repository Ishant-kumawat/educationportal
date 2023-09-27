import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContinuelearningComponent } from './continuelearning.component';

describe('ContinuelearningComponent', () => {
  let component: ContinuelearningComponent;
  let fixture: ComponentFixture<ContinuelearningComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ContinuelearningComponent]
    });
    fixture = TestBed.createComponent(ContinuelearningComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
