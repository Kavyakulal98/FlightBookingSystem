import { Component, OnInit } from '@angular/core';
import { ManageairlineService } from 'src/app/service/manageairline.service';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl,FormsModule ,ReactiveFormsModule } from '@angular/forms';   
import { Router } from '@angular/router';
import { Manageairline } from 'src/app/model/manageairline.model';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-airline',
  templateUrl: './airline.component.html',
  styleUrls: ['./airline.component.css']
})
export class AirlineComponent implements OnInit {
  
  constructor(private router:Router, public service:ManageairlineService,private toastr:ToastrService) { }
  success:boolean=false;
  ngOnInit(): void {
    // this.AirlineForm = this.formbulider.group({    
    //   AirlineName: ['', [Validators.required]],    
    //   AirlineContactNumber: ['', [Validators.required]],    
    //   AirlineAddress: ['', [Validators.required]],    
    //   EmailAddress: ['', [Validators.required]],    
    //   IsBlocked: ['', [Validators.required]],       
    // }); 
  }
  onAirlineFormsubmit(form:NgForm){
    // const airlinevalues = this.AirlineForm.value;

    this.service.AddAirline().subscribe(
      (response)=>{
        console.log(response);
        // if(this.success == true){
          this.refreshData(form);
          this.router.navigate(['flightuser/admindashoboard']); 
          this.toastr.success("Added successfully"); 
        // }else{
        //   this.toastr.error("Same airline exists");
        // }
        
      }
    );
    
  }
  refreshData(form:NgForm){
    form.form.reset();
    this.service.AirlineForm = new Manageairline();
  }

}
