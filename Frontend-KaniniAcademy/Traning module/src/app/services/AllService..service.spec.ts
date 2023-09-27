import { TestBed } from '@angular/core/testing';

import { AllService } from './AllService.service';

describe('AllService', () => {
  let service: AllService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AllService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
