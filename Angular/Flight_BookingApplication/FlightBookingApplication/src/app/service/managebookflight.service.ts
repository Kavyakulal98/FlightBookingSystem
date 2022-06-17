import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Managebookflight } from '../model/managebookflight.model';
import { Manageinventory } from '../model/manageinventory.model';
import { Searchairline } from '../model/searchairline.model';

@Injectable({
  providedIn: 'root'
})
export class ManagebookflightService {

  Url: string;
  constructor(private http: HttpClient) {
    this.Url = 'http://localhost:7000/';
  }
  bookVariable:Managebookflight = new Managebookflight;
  //bookVariable:any;
  passengerVariable: any[]=[];
  airlinename:string='';
 searchForm:Manageinventory=new Manageinventory;
  // searchForm: any[] = [];
  Bookflight() {
    debugger
    return this.http.post(this.Url + 'bookFlight', this.bookVariable);
  }
  SearchAirline():Observable<any>{
    debugger
    return this.http.post(this.Url + 'searchFlight/'+this.airlinename,this.searchForm);   
  }
  GetBookingHistory(userId:number):Observable<any>{
    debugger
    return this.http.get(this.Url + 'getBookinghistoryByuserId/'+userId+'/'+true);   
  }
  GetBookingHistorybyPnr(pnrId:number):Observable<any>{
    debugger
    return this.http.get(this.Url + 'getBookingInfoByPnr/'+pnrId);   
  }
  CancelBooking(id:number):Observable<any>{
    debugger
    return this.http.delete(this.Url + 'cancelBooking/'+id);   
  }
}
