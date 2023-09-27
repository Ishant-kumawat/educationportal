import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewsecondComponent } from './viewsecond.component';

describe('ViewsecondComponent', () => {
  let component: ViewsecondComponent;
  let fixture: ComponentFixture<ViewsecondComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ViewsecondComponent]
    });
    fixture = TestBed.createComponent(ViewsecondComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
