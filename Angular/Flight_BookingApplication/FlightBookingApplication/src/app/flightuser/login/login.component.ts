import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';    
import { LoginService } from '../../login.service';    
 import { FormsModule } from '@angular/forms'; 
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model : any={};    
    
  errorMessage:string='';    
  constructor(private router:Router,private LoginService:LoginService) { }    
    
    
  ngOnInit() {    
    sessionStorage.removeItem('UserName');    
    sessionStorage.clear();    
  }    
  login(){    
    debugger;    
    this.LoginService.Login(this.model).subscribe(    
      data => {    
        debugger; 
        console.log(data)  ;
        const token = data.response;
        // if(data != null)    
        // {       
        //   this.router.navigate(['/Flightuser']);    
        //   debugger;    
        // }    
        // else{    
        //   this.errorMessage = data.Message;    
        // }    
      },    
      error => {    
        this.errorMessage = error.message;    
      });    
  };    
 }     