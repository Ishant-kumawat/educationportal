import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VcexercisefilesComponent } from './vcexercisefiles.component';

describe('VcexercisefilesComponent', () => {
  let component: VcexercisefilesComponent;
  let fixture: ComponentFixture<VcexercisefilesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VcexercisefilesComponent]
    });
    fixture = TestBed.createComponent(VcexercisefilesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
