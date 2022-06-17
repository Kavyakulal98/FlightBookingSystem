import { analyzeAndValidateNgModules } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Managebookflight } from 'src/app/model/managebookflight.model';
import { Manageinventory } from 'src/app/model/manageinventory.model';
import { ManagebookflightService } from 'src/app/service/managebookflight.service';
import { TokenStorageService } from 'src/app/service/token-storage.service';

@Component({
  selector: 'app-userdashboard',
  templateUrl: './userdashboard.component.html',
  styleUrls: ['./userdashboard.component.css']
})
export class UserdashboardComponent implements OnInit {
  listSearchedData:  Array<any>=[];
  userId: any;
  constructor(private router:Router, public service:ManagebookflightService,public tokenStorage:TokenStorageService) { }
  
 // listSearchedData:Manageinventory=new Manageinventory();
  ngOnInit(): void {
    this.userId = this.tokenStorage.getUser().userId;
  }
  
  // airlineName:string='';
  onSearchFormsubmit(form:NgForm){
    // const airlinevalues = this.AirlineForm.value;
    debugger
    this.service.SearchAirline().subscribe(
      (data)=>{
        // this.success =data;
        debugger
         if(data != null){
          console.log(data);
          this.listSearchedData = data; 
          this.refreshData(form);
          
          
         }else{
           debugger
          this.listSearchedData;
         }     
      }
    );   
  }
  refreshData(form:NgForm){
    form.form.reset();
    this.service.searchForm=new Manageinventory;
  }

  Logout(){
    this.tokenStorage.signOut();
    this.router.navigate(['flightuser/login']);
  }

}
