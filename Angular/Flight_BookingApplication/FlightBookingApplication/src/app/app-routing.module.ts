import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FlightuserComponent } from './flightuser/flightuser.component';
import { ResgisterComponent } from './flightuser/resgister/resgister.component';
import { LoginComponent } from './flightuser/login/login.component';
import { AirlineComponent } from './flightuser/airline/airline.component';
import { AdmindashoboardComponent } from './flightuser/admindashoboard/admindashoboard.component';
import { InventoryComponent } from './flightuser/inventory/inventory.component';
import { InventorydashboardComponent } from './flightuser/inventorydashboard/inventorydashboard.component';

   
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
  {    
    path: 'flightuser/airline',    
    component: AirlineComponent,    
    data: {    
      title: 'Add Airline Page'    
    }    
  }, 
  {    
    path: 'flightuser/admindashoboard',    
    component: AdmindashoboardComponent,    
    data: {    
      title: 'admin Page'    
    }    
  },   
  {    
    path: 'flightuser/inventorydashboard/:id',    
    component: InventorydashboardComponent,    
    data: {    
      title: 'inventory Page'    
    }    
  },  
   {    
    path: 'flightuser/inventory/:id',    
    component: InventoryComponent,    
    data: {    
      title: 'inventory Page'    
    }    
  },  
];    
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
  
 
export class AppRoutingModule { } 