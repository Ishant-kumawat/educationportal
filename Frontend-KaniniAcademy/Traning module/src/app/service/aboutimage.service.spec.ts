import { TestBed } from '@angular/core/testing';

import { AboutimageService } from './aboutimage.service';

describe('AboutimageService', () => {
  let service: AboutimageService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AboutimageService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
