import { Component, OnInit } from '@angular/core';
import { LoginService } from 'src/app/login.service';    
import { Resgister } from 'src/app/resgister';  
import {Observable} from 'rxjs';    
import { Router } from '@angular/router';   
import { NgForm, FormBuilder, FormGroup, Validators, FormControl,FormsModule ,ReactiveFormsModule } from '@angular/forms';   
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-resgister',
  templateUrl: './resgister.component.html',
  styleUrls: ['./resgister.component.css']
})
export class ResgisterComponent implements OnInit {
     
  data = false;    
  UserForm: any;    
  massage!:string;    
  constructor(private router:Router,private formbulider: FormBuilder,private loginService:LoginService,private toastr:ToastrService) { }    
    
  ngOnInit() {    
    this.UserForm = this.formbulider.group({    
      UserName: ['', [Validators.required]],    
      Age: ['', [Validators.required]],    
      Password: ['', [Validators.required]],    
      EmailAddress: ['', [Validators.required,Validators.email]],    
      ContactNumber: ['', [Validators.required]],       
    });    
  }    
  
   onFormSubmit()    
  {    debugger;
    const user = this.UserForm.value;    
    this.Createemployee(user);    
  }    
  Createemployee(register:Resgister)    
  {    
    debugger;
  this.loginService.CreateUser(register).subscribe(    
    (response)=>    
    {    
      this.data = true;    
      this.massage = 'Data saved Successfully';    
      this.UserForm.reset(); 
      this.router.navigate(['/flightuser/login']);  
      this.toastr.success("Registered successfully");  
    });    
  }    
}    
