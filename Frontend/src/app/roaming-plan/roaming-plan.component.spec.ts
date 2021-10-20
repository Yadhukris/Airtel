import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RoamingPlanComponent } from './roaming-plan.component';

describe('RoamingPlanComponent', () => {
  let component: RoamingPlanComponent;
  let fixture: ComponentFixture<RoamingPlanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RoamingPlanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RoamingPlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
