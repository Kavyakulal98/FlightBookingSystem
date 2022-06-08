import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlightuserComponent } from './flightuser.component';

describe('FlightuserComponent', () => {
  let component: FlightuserComponent;
  let fixture: ComponentFixture<FlightuserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FlightuserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FlightuserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
