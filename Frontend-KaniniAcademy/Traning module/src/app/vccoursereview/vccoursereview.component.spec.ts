import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VccoursereviewComponent } from './vccoursereview.component';

describe('VccoursereviewComponent', () => {
  let component: VccoursereviewComponent;
  let fixture: ComponentFixture<VccoursereviewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VccoursereviewComponent]
    });
    fixture = TestBed.createComponent(VccoursereviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
