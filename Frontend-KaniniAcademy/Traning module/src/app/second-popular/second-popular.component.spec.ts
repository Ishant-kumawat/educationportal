import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecondPopularComponent } from './second-popular.component';

describe('SecondPopularComponent', () => {
  let component: SecondPopularComponent;
  let fixture: ComponentFixture<SecondPopularComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SecondPopularComponent]
    });
    fixture = TestBed.createComponent(SecondPopularComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
