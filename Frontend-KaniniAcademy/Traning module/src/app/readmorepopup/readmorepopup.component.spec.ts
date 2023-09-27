import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadmorepopupComponent } from './readmorepopup.component';

describe('ReadmorepopupComponent', () => {
  let component: ReadmorepopupComponent;
  let fixture: ComponentFixture<ReadmorepopupComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReadmorepopupComponent]
    });
    fixture = TestBed.createComponent(ReadmorepopupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
