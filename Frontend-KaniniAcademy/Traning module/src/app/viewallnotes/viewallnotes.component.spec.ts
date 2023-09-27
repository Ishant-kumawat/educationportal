import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewallnotesComponent } from './viewallnotes.component';

describe('ViewallnotesComponent', () => {
  let component: ViewallnotesComponent;
  let fixture: ComponentFixture<ViewallnotesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ViewallnotesComponent]
    });
    fixture = TestBed.createComponent(ViewallnotesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
