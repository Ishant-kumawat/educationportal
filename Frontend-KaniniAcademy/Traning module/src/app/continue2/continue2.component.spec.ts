import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Continue2Component } from './continue2.component';

describe('Continue2Component', () => {
  let component: Continue2Component;
  let fixture: ComponentFixture<Continue2Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Continue2Component]
    });
    fixture = TestBed.createComponent(Continue2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
