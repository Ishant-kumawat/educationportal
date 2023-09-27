import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrendingBlogComponent } from './trending-blog.component';

describe('TrendingBlogComponent', () => {
  let component: TrendingBlogComponent;
  let fixture: ComponentFixture<TrendingBlogComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TrendingBlogComponent]
    });
    fixture = TestBed.createComponent(TrendingBlogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
