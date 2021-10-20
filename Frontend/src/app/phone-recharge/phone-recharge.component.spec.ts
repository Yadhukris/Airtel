import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhoneRechargeComponent } from './phone-recharge.component';

describe('PhoneRechargeComponent', () => {
  let component: PhoneRechargeComponent;
  let fixture: ComponentFixture<PhoneRechargeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhoneRechargeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhoneRechargeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
