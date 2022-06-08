import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule }from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt"
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FlightuserComponent } from './flightuser/flightuser.component';
import { ResgisterComponent } from './flightuser/resgister/resgister.component';
import { LoginComponent } from './flightuser/login/login.component';
import { FormsModule ,ReactiveFormsModule} from '@angular/forms';

export function tokenGetter() { 
  return localStorage.getItem("jwt"); 
}
@NgModule({
  declarations: [
    AppComponent,
    FlightuserComponent,
    ResgisterComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ["localhost:7000"],
        disallowedRoutes: []
      }
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
