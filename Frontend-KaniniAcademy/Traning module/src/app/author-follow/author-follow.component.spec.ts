import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthorFollowComponent } from './author-follow.component';

describe('AuthorFollowComponent', () => {
  let component: AuthorFollowComponent;
  let fixture: ComponentFixture<AuthorFollowComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AuthorFollowComponent]
    });
    fixture = TestBed.createComponent(AuthorFollowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
