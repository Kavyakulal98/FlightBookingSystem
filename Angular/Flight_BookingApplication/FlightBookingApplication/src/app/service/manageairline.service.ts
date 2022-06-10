import { Injectable } from '@angular/core';
import { HttpClient,HttpParams,HttpHeaders } from '@angular/common/http';
import { Manageairline } from '../model/manageairline.model';
import { map, Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ManageairlineService {
  Url: string;
  constructor(private http: HttpClient) {
    this.Url = 'http://localhost:7000/';
  }
  AirlineForm: Manageairline = new Manageairline(); 
  //listAirlines: Manageairline[] = [];
  //listAirlines: Manageairline[] = [];
  //listAirlines!: Observable<Manageairline[]>;
  AddAirline() {
    debugger
    this.AirlineForm.IsBlocked=false;
    return this.http.post(this.Url + 'insertAirline', this.AirlineForm);
  }
  getAllAirline():Observable<any>{
    debugger
    return this.http.get(this.Url + 'getAllAirline');   
  }
  blockAirline(airline:any){
    debugger
    return this.http.put(this.Url + 'blockAirline',airline);   
  }
  
}
