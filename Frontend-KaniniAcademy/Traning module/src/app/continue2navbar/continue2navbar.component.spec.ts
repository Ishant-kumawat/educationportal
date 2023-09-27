import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Continue2navbarComponent } from './continue2navbar.component';

describe('Continue2navbarComponent', () => {
  let component: Continue2navbarComponent;
  let fixture: ComponentFixture<Continue2navbarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Continue2navbarComponent]
    });
    fixture = TestBed.createComponent(Continue2navbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
