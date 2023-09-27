import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserexpcoursesComponent } from './userexpcourses.component';

describe('UserexpcoursesComponent', () => {
  let component: UserexpcoursesComponent;
  let fixture: ComponentFixture<UserexpcoursesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserexpcoursesComponent]
    });
    fixture = TestBed.createComponent(UserexpcoursesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
