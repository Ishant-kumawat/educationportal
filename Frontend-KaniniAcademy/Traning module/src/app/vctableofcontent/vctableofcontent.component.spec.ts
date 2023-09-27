import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VctableofcontentComponent } from './vctableofcontent.component';

describe('VctableofcontentComponent', () => {
  let component: VctableofcontentComponent;
  let fixture: ComponentFixture<VctableofcontentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VctableofcontentComponent]
    });
    fixture = TestBed.createComponent(VctableofcontentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
