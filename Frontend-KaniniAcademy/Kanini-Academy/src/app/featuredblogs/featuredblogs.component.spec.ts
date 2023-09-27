import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeaturedblogsComponent } from './featuredblogs.component';

describe('FeaturedblogsComponent', () => {
  let component: FeaturedblogsComponent;
  let fixture: ComponentFixture<FeaturedblogsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FeaturedblogsComponent]
    });
    fixture = TestBed.createComponent(FeaturedblogsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
