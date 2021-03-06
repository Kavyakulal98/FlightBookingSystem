import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule }from '@angular/common/http';
// import { JwtModule } from "@auth0/angular-jwt"
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FlightuserComponent } from './flightuser/flightuser.component';
import { ResgisterComponent } from './flightuser/resgister/resgister.component';
import { LoginComponent } from './flightuser/login/login.component';
import { FormsModule ,ReactiveFormsModule} from '@angular/forms';
import { AdmindashoboardComponent } from './flightuser/admindashoboard/admindashoboard.component';
import { AirlineComponent } from './flightuser/airline/airline.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { InventoryComponent } from './flightuser/inventory/inventory.component';
import { InventorydashboardComponent } from './flightuser/inventorydashboard/inventorydashboard.component';
import { UserdashboardComponent } from './flightuser/userdashboard/userdashboard.component';
import { UserbookflightComponent } from './flightuser/userbookflight/userbookflight.component';
import { authInterceptorProviders } from './flightuser/_helpers/auth.interceptors';
import { BookinghistoryComponent } from './flightuser/bookinghistory/bookinghistory.component';
import { ViewbookingComponent } from './flightuser/viewbooking/viewbooking.component';
// export function tokenGetter() { 
//   return localStorage.getItem("jwt"); 
// }
@NgModule({
  declarations: [
    AppComponent,
    FlightuserComponent,
    ResgisterComponent,
    LoginComponent,
    AdmindashoboardComponent,
    AirlineComponent,
    InventoryComponent,
    InventorydashboardComponent,
    UserdashboardComponent,
    UserbookflightComponent,
    BookinghistoryComponent,
    ViewbookingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
    // JwtModule.forRoot({
    //   config: {
    //     tokenGetter: tokenGetter,
    //     allowedDomains: ["localhost:7000"],
    //     disallowedRoutes: []
    //   }
    // })
  ],
  providers: [authInterceptorProviders],
  bootstrap: [AppComponent]
})
export class AppModule { }
