import { TestBed } from '@angular/core/testing';

import { ManagebookflightService } from './managebookflight.service';

describe('ManagebookflightService', () => {
  let service: ManagebookflightService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ManagebookflightService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
