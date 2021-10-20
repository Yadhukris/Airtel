import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DataPlanComponent } from './data-plan/data-plan.component';
import { HomeComponent } from './home/home.component';
import { InternationalComponent } from './international/international.component';
import { LoginComponent } from './login/login.component';
import { PhoneRechargeComponent } from './phone-recharge/phone-recharge.component';
import { RoamingPlanComponent } from './roaming-plan/roaming-plan.component';

const routes: Routes = [
  {path:'',component:LoginComponent},
  {path:'Home',component:HomeComponent},
  {path:'Phone',component:PhoneRechargeComponent},
  {path:'Data',component:DataPlanComponent},
  {path:'Roaming',component:RoamingPlanComponent},
  {path:'Inter',component:InternationalComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
