import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';    
import { LoginService } from '../../login.service';    
 import { FormsModule } from '@angular/forms'; 
import { ToastrService } from 'ngx-toastr';
import { TokenStorageService } from 'src/app/service/token-storage.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model : any={};    
    
  errorMessage:string='';    
  isSuccessful: boolean = false;
  isSignUpFailed: boolean =false;
  // tokenStorage: any;
  isLoggedIn: boolean =false;
  roles: string='';
  // Email: any;
  userName: any;
  userId: any;
  constructor(private router:Router,private LoginService:LoginService,public toster:ToastrService, private tokenStorage:TokenStorageService) { }    
    
  param:any;
  ngOnInit() {    
    // sessionStorage.removeItem('UserName');    
    // sessionStorage.clear();   
    if (this.tokenStorage.getToken()) {
      // this.isLoggedIn = true;
      debugger;
      this.roles = this.tokenStorage.getUser().role;
    } 
  }    
  login(){    
    debugger;    
    this.LoginService.Login(this.model).subscribe((data) => { 
      debugger; console.log(data);
      this.param = data;
      if(this.param.response != null){
        debugger
        this.tokenStorage.saveToken(this.param.response);
        this.tokenStorage.saveUser(this.param.user);
  
        this.roles = this.tokenStorage.getUser().role;
        this.userName = this.tokenStorage.getUser().userName;
        this.userId = this.tokenStorage.getUser().userId;
        console.log(this.roles,this.userName,this.userId)
        // this.toster("Login successful");
        // this.isSuccessful = true;
        //   this.isSignUpFailed = false;
        if(this.roles == "Admin"){
          this.router.navigate(['/flightuser/admindashoboard']); 
        }else{
          this.router.navigate(['/flightuser/userdashboard']); 
        }
      }
        if(this.param.success == 0){
        this.toster.error("User does not exist.Please register.")
      }
     
       
      // localStorage.key = data.response;
    },
    // error => {
    //   // this.errorMessage = err.error.message;
    //  this.isSignUpFailed = true;
    // }
    );    
  };    
 }     
