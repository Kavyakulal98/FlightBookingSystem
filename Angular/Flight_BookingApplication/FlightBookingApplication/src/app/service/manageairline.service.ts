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
  //listAirlines!: Observable<Manageairline[]>;
  AddAirline() {
    debugger
    this.AirlineForm.IsBlocked=false;
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post(this.Url + 'insertAirline', this.AirlineForm,httpOptions);
  }
  getAllAirline():Observable<any>{
    debugger
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
     return this.http.get(this.Url + 'getAllAirline',httpOptions);   
  }
  getAirlinebyId(id:number){
    debugger
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
     return this.http.get(this.Url + 'getAirlinebyId/'+id,httpOptions);   
  }
  blockAirline(airline:any){
    debugger
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put(this.Url + 'blockAirline',airline,httpOptions);   
  }
  deleteAirline(id:number){
    debugger
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete(this.Url + 'deleteAirline/'+id,httpOptions); 
  }
  
}
