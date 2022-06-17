import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Manageinventory } from '../model/manageinventory.model';

@Injectable({
  providedIn: 'root'
})
export class ManageinventoryService {

  Url: string;
  constructor(private http: HttpClient) {
    this.Url = 'http://localhost:7000/';
  }
  inventoryVariable:Manageinventory = new Manageinventory;
  AddInventory() {
    debugger
    return this.http.post(this.Url + 'insertInventory', this.inventoryVariable);
  }
  getAllInventory(inputId:number,value:boolean):Observable<any>{
    debugger
    return this.http.get(this.Url + 'getAllInventory/'+inputId+'/'+value);   
  }

  getInventorybyId(id:number):Observable<any>{
    return this.http.get(this.Url + 'getInventorybyId/'+id); 
  }

}
