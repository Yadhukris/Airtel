import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { PhoneRechargeComponent } from './phone-recharge/phone-recharge.component';
import { DataPlanComponent } from './data-plan/data-plan.component';
import { RoamingPlanComponent } from './roaming-plan/roaming-plan.component';
import { InternationalComponent } from './international/international.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    PhoneRechargeComponent,
    DataPlanComponent,
    RoamingPlanComponent,
    InternationalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
