import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';  
import {HttpHeaders} from '@angular/common/http';  
import { from, Observable } from 'rxjs';  
import { Resgister } from '../app/resgister';
@Injectable({
  providedIn: 'root'
})
export class LoginService {
  Url :string;  
  token! : string;  
  // header : any;  
  constructor(private http:HttpClient) {   
  
    this.Url = 'http://localhost:7000/';  
  
    // const headerSettings: {[name: string]: string | string[]; } = {};  
    // this.header = new HttpHeaders(headerSettings); 
  
} 
Login(model : any)
{  
  debugger;  
   //var a =this.Url+'loginUser';  
 //var b = this.http.post<any>(this.Url+'loginUser',model,{ headers: this.header});
 //return b; 
return this.http.post(this.Url+'loginUser',model);
}  
 CreateUser(register:Resgister)  
 {  
   debugger;
  register.Role='User';
  const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };  
  return this.http.post<Resgister[]>(this.Url + 'registerUser/', register, httpOptions)  
 }  
}  
