import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FreeresourceNavbarComponent } from './freeresource-navbar.component';

describe('FreeresourceNavbarComponent', () => {
  let component: FreeresourceNavbarComponent;
  let fixture: ComponentFixture<FreeresourceNavbarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FreeresourceNavbarComponent]
    });
    fixture = TestBed.createComponent(FreeresourceNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
