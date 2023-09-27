import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardpopularComponent } from './cardpopular.component';

describe('CardpopularComponent', () => {
  let component: CardpopularComponent;
  let fixture: ComponentFixture<CardpopularComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CardpopularComponent]
    });
    fixture = TestBed.createComponent(CardpopularComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
