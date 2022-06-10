import { TestBed } from '@angular/core/testing';

import { ManageairlineService } from './manageairline.service';

describe('ManageairlineService', () => {
  let service: ManageairlineService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ManageairlineService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
