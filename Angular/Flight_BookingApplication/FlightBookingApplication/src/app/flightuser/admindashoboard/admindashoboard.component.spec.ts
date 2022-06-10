import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdmindashoboardComponent } from './admindashoboard.component';

describe('AdmindashoboardComponent', () => {
  let component: AdmindashoboardComponent;
  let fixture: ComponentFixture<AdmindashoboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdmindashoboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdmindashoboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
