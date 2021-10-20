import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataPlanComponent } from './data-plan.component';

describe('DataPlanComponent', () => {
  let component: DataPlanComponent;
  let fixture: ComponentFixture<DataPlanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataPlanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DataPlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
