import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VctranscriptComponent } from './vctranscript.component';

describe('VctranscriptComponent', () => {
  let component: VctranscriptComponent;
  let fixture: ComponentFixture<VctranscriptComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VctranscriptComponent]
    });
    fixture = TestBed.createComponent(VctranscriptComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
