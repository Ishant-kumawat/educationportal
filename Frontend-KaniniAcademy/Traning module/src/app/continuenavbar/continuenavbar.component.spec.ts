import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContinuenavbarComponent } from './continuenavbar.component';

describe('ContinuenavbarComponent', () => {
  let component: ContinuenavbarComponent;
  let fixture: ComponentFixture<ContinuenavbarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ContinuenavbarComponent]
    });
    fixture = TestBed.createComponent(ContinuenavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
