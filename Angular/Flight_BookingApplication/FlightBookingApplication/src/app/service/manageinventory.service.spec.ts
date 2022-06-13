import { TestBed } from '@angular/core/testing';

import { ManageinventoryService } from './manageinventory.service';

describe('ManageinventoryService', () => {
  let service: ManageinventoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ManageinventoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
