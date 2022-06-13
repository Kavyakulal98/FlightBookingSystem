import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
// import { Console } from 'console';
import { ToastrService } from 'ngx-toastr';
import { Manageinventory } from 'src/app/model/manageinventory.model';
import { ManageinventoryService } from 'src/app/service/manageinventory.service';


@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.css']
})
export class InventoryComponent implements OnInit {

  constructor(private router:Router, public service:ManageinventoryService,private toastr:ToastrService,private activatedrout:ActivatedRoute) { }
  success:any;
  airlinesId!:any;
  ngOnInit(): void {
    this.activatedrout.paramMap.subscribe((params)=>this.airlinesId=params.get('id'));
    this.service.inventoryVariable.AirlinesId = this.airlinesId;
  }
  
  onInventoryFormsubmit(form:NgForm){
    // const airlinevalues = this.AirlineForm.value;
    this.service.AddInventory().subscribe(
      (data)=>{
        this.success =data;
        console.log(data);
        debugger
         if(this.success.apiresponse == true){
          debugger; 
          this.refreshData(form);
          this.router.navigate(['flightuser/inventorydashboard/:this.airlinesId']); 
          this.toastr.success("Inventory Added successfully"); 
         }else{
          this.toastr.error("Cannot add Inventory");
         }     
      }
    );   
  }
  refreshData(form:NgForm){
    form.form.reset();
    this.service.inventoryVariable = new Manageinventory();
  }
}
