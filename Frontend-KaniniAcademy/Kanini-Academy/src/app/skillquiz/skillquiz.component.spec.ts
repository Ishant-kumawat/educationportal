import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillquizComponent } from './skillquiz.component';

describe('SkillquizComponent', () => {
  let component: SkillquizComponent;
  let fixture: ComponentFixture<SkillquizComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SkillquizComponent]
    });
    fixture = TestBed.createComponent(SkillquizComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
