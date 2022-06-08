import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FlightuserComponent } from './flightuser/flightuser.component';
import { ResgisterComponent } from './flightuser/resgister/resgister.component';
import { LoginComponent } from './flightuser/login/login.component';

   
export const routes: Routes = [    
  {    
    path: '',    
    redirectTo: 'flightuser/login',    
    pathMatch: 'full',    
  },    
  {    
    path: 'flightuser/login',    
    component: LoginComponent,    
    data: {    
      title: 'Login Page'    
    }    
  },    
  {    
    path: 'flightuser',    
    component: FlightuserComponent,    
    data: {    
      title: 'Dashboard Page'    
    }    
  },    
  {    
    path: 'flightuser/resgister',    
    component: ResgisterComponent,    
    data: {    
      title: 'Add User Page'    
    }    
  },    
];    
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
  
 
export class AppRoutingModule { } 