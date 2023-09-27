import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrendingcardComponent } from './trendingcard.component';

describe('TrendingcardComponent', () => {
  let component: TrendingcardComponent;
  let fixture: ComponentFixture<TrendingcardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TrendingcardComponent]
    });
    fixture = TestBed.createComponent(TrendingcardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
