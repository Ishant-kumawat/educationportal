import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Continue1Component } from './continue1.component';

describe('Continue1Component', () => {
  let component: Continue1Component;
  let fixture: ComponentFixture<Continue1Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Continue1Component]
    });
    fixture = TestBed.createComponent(Continue1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
