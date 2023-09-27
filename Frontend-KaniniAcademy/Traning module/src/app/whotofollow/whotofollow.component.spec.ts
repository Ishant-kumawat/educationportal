import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WhotofollowComponent } from './whotofollow.component';

describe('WhotofollowComponent', () => {
  let component: WhotofollowComponent;
  let fixture: ComponentFixture<WhotofollowComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [WhotofollowComponent]
    });
    fixture = TestBed.createComponent(WhotofollowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
