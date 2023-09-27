import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CctableofcontentsComponent } from './cctableofcontents.component';

describe('CctableofcontentsComponent', () => {
  let component: CctableofcontentsComponent;
  let fixture: ComponentFixture<CctableofcontentsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CctableofcontentsComponent]
    });
    fixture = TestBed.createComponent(CctableofcontentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
