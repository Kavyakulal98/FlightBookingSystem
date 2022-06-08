import { Component, OnInit } from '@angular/core';
import { LoginService } from 'src/app/login.service';    
import { Resgister } from 'src/app/resgister';  
import {Observable} from 'rxjs';    
import { NgForm, FormBuilder, FormGroup, Validators, FormControl,FormsModule ,ReactiveFormsModule } from '@angular/forms';   

@Component({
  selector: 'app-resgister',
  templateUrl: './resgister.component.html',
  styleUrls: ['./resgister.component.css']
})
export class ResgisterComponent implements OnInit {
     
  data = false;    
  UserForm: any;    
  massage!:string;    
  constructor(private formbulider: FormBuilder,private loginService:LoginService) { }    
    
  ngOnInit() {    
    this.UserForm = this.formbulider.group({    
      UserName: ['', [Validators.required]],    
      Age: ['', [Validators.required]],    
      Password: ['', [Validators.required]],    
      EmailAddress: ['', [Validators.required]],    
      ContactNumber: ['', [Validators.required]],       
    });    
  }    
   onFormSubmit()    
  {    
    const user = this.UserForm.value;    
    this.Createemployee(user);    
  }    
  Createemployee(register:Resgister)    
  {    
  this.loginService.CreateUser(register).subscribe(    
    ()=>    
    {    debugger;
      this.data = true;    
      this.massage = 'Data saved Successfully';    
      this.UserForm.reset();    
    });    
  }    
}    
