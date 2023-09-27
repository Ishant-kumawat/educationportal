import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecondcardComponent } from './secondcard.component';

describe('SecondcardComponent', () => {
  let component: SecondcardComponent;
  let fixture: ComponentFixture<SecondcardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SecondcardComponent]
    });
    fixture = TestBed.createComponent(SecondcardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
