import { ComponentFixture, TestBed } from '@angular/core/testing';
import { TrainingandCertificatesComponent } from './trainingand-certificates.component';

describe('TrainingandCertificatesComponent', () => {
  let component: TrainingandCertificatesComponent;
  let fixture: ComponentFixture<TrainingandCertificatesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TrainingandCertificatesComponent]
    });
    fixture = TestBed.createComponent(TrainingandCertificatesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
