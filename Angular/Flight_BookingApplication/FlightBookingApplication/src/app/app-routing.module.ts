import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FlightuserComponent } from './flightuser/flightuser.component';
import { ResgisterComponent } from './flightuser/resgister/resgister.component';
import { LoginComponent } from './flightuser/login/login.component';
import { AirlineComponent } from './flightuser/airline/airline.component';
import { AdmindashoboardComponent } from './flightuser/admindashoboard/admindashoboard.component';
import { InventoryComponent } from './flightuser/inventory/inventory.component';
import { InventorydashboardComponent } from './flightuser/inventorydashboard/inventorydashboard.component';
import { UserdashboardComponent } from './flightuser/userdashboard/userdashboard.component';
import { UserbookflightComponent } from './flightuser/userbookflight/userbookflight.component';
import { BookinghistoryComponent } from './flightuser/bookinghistory/bookinghistory.component';
import { CommonModule } from '@angular/common';  
import { BrowserModule } from '@angular/platform-browser'; 
import { ViewbookingComponent } from './flightuser/viewbooking/viewbooking.component';
   
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
  {    
    path: 'flightuser/userdashboard',    
    component: UserdashboardComponent,    
    data: {    
      title: 'user Page'    
    }    
  }, 
  {    
    path: 'flightuser/userbookflight/:airlinesId/:inventoryId/:userId',    
    component: UserbookflightComponent,    
    data: {    
      title: 'inventory Page'    
    }    
  }, 
  {    
    path: 'flightuser/bookinghistory/:userId',    
    component: BookinghistoryComponent,    
    data: {    
      title: 'booking history Page'    
    }    
  }, 
  {    
    path: 'flightuser/viewbooking/:flightBookingId/:airlinesId/:inventoryId/:userId',    
    component: ViewbookingComponent,    
    data: {    
      title: 'view history Page'    
    }    
  },
];    
@NgModule({
  imports: [RouterModule.forRoot(routes),CommonModule],
  exports: [RouterModule]
})
  
 
export class AppRoutingModule { } 