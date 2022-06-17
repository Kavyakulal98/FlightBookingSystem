import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Managebookflight, passengersDetails } from 'src/app/model/managebookflight.model';
import { ManagebookflightService } from 'src/app/service/managebookflight.service';
import { ManageinventoryService } from 'src/app/service/manageinventory.service';

@Component({
  selector: 'app-userbookflight',
  templateUrl: './userbookflight.component.html',
  styleUrls: ['./userbookflight.component.css']
})
export class UserbookflightComponent implements OnInit {
  seatList:any = ["BusinessClass", "NonBusinessClass"];
  dynamicArray: Array<passengersDetails> = [];  
  newDynamic: any = {}; 
  
  
  constructor(private router:Router, public service:ManagebookflightService,public invservice:ManageinventoryService,private toastr:ToastrService,public activatedrout:ActivatedRoute) { }
  response:any;
  
  airlinesId!: any;
  inventoryId!: any;
  userId!: any;
  priceperticket!:any;
  pricepertickettax!:any;
  discountCode:string='D345K';
  invDetails!: any;
  discountApplied:boolean=false;
  amounttobePaid!:any;
  count:number=1;
  
  ngOnInit(): void {
    this.activatedrout.paramMap.subscribe((params)=>this.airlinesId=params.get('airlinesId'));
    this.activatedrout.paramMap.subscribe((params)=>this.inventoryId=params.get('inventoryId'));
    this.activatedrout.paramMap.subscribe((params)=>this.userId=params.get('userId'));
        // this.newDynamic = {Name: "", Age: 0,Gender:"",SeatNumber:"",Seats:""};
        this.service.bookVariable.AirlinesId = this.airlinesId;
        this.service.bookVariable.InventoryId = this.inventoryId;
        this.service.bookVariable.UserId = this.userId;
        this.invservice.getInventorybyId(this.inventoryId).subscribe(
          (data)=>{ 
            debugger
          this.invDetails = data;
          console.log(data);
          this.invservice.inventoryVariable =this.invDetails;
          this.pricepertickettax=this.invDetails.airlineTotalCost;
          this.priceperticket=this.invDetails.airlinePrice;   
          this.amounttobePaid=this.pricepertickettax;
        }
          );
          
          
  }
  
  // changeWebsite(e:any) {  
  //   console.log(e.target.value);  
  // }  
  onbookFlightFormsubmit(form:NgForm){
    debugger
    this.service.bookVariable.passengers=this.dynamicArray;
    if(this.newDynamic != null){
      this.service.bookVariable.passengers.push(this.newDynamic);
    }
    if(this.discountApplied == true){
      this.service.bookVariable.isdiscountApplied = true;
    }
    this.service.bookVariable.amountPaid=this.amounttobePaid;
    this.service.Bookflight().subscribe((data)=>{
      debugger
      this.response=data;
      if(this.response.apiresponse == true){
        this.refreshData(form);
        this.router.navigate(['flightuser/userdashboard']); 
        this.toastr.success("Booked successfully"); 
      }else{
        this.toastr.error("cannot book ticket"); 
      }
    });
  }
  refreshData(form:NgForm){
    form.form.reset();
    this.service.bookVariable = new Managebookflight();
    this.dynamicArray=new Array<passengersDetails>();
    this.newDynamic={};

  }
  applyDiscount(code:string){
    debugger
    if(code == this.discountCode){
      if(this.count!=0){
        this.amounttobePaid = (this.pricepertickettax*this.count)-100 ;
       
      }else{
        this.amounttobePaid = (this.pricepertickettax-100) ;
              }
              this.discountApplied=true;
        this.toastr.success("Discount applied successfully");


    }else{
      if(this.count!=0){
        this.amounttobePaid = (this.pricepertickettax*this.count);
       
      }else{
        this.amounttobePaid = this.pricepertickettax ;
              }
      // this.amounttobePaid = this.pricepertickettax;
      this.toastr.error("Discount code is not valid"); 
      this.discountApplied=false;
    }
  }
  addRow() {   
    debugger 
    //  this.newDynamic = {Name: "", Age: 0,Gender:"",SeatNumber:"",Seats:""}; 
  //  this.newDynamic = new passengersDetails();
    //this.newDynamic = {};
    this.dynamicArray.push(this.newDynamic);
  // this.service.bookVariable.passenger.push(this.newDynamic);  
    // this.dynamicArray.push(this.newDynamic)
         this.newDynamic = {};
    // this.toastr.success('New row added successfully', 'New Row');  
     console.log(this.dynamicArray); 
     this.count=this.count+1;
     this.amounttobePaid = (this.pricepertickettax*this.count) 
    //  console.log(this.dynamicArray[0]); 
}  
  
deleteRow(index:number) {  
    if(this.dynamicArray.length ==1) {  
      this.toastr.error("Can't delete the row", 'Warning');  
        return false;  
    } else {
      debugger  
      // this.service.bookVariable.passenger.splice(index, 1);
        this.dynamicArray.splice(index, 1);  
        this.count=this.count-1; 
        this.toastr.warning('Row deleted successfully', 'Delete row'); 
        this.amounttobePaid = (this.pricepertickettax*this.count)
        return true;  
    }  
}

  
  // Addnewrow(){
  //   // <div class="card mx-4">  
  //   //             <div class="card-body p-4"> 
  //   //                 <div class="input-group mb-3">  
           
  //   //                     <input type="text" class="form-control" placeholder="Name" 
  //   //                     name="Name" #Name="ngModel" [(ngModel)]="service.bookVariable.passenger.Name" required>  
  //   //                     <input type="text" class="form-control" placeholder="Age" 
  //   //                     name="Age" #Age="ngModel" [(ngModel)]="service.bookVariable.passenger.Age" required>  
  //   //                     <input type="number" class="form-control" placeholder="Gender" 
  //   //                     name="Gender" #Gender="ngModel" [(ngModel)]="service.bookVariable.passenger.Gender" required>  
  //   //                     <button type="submit" (click)="Addnewrow()">new row </button>
                      
  //   //                   </div> 
  //   //                 </div>
  //   //                 </div>
  //   let string = "";
  // }
}
