import { TestBed } from '@angular/core/testing';

import { DetailcertService } from './detailcert.service';

describe('DetailcertService', () => {
  let service: DetailcertService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DetailcertService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
