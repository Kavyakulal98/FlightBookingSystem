import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ManageairlineService } from 'src/app/service/manageairline.service';
import { ManagebookflightService } from 'src/app/service/managebookflight.service';
import { ManageinventoryService } from 'src/app/service/manageinventory.service';

@Component({
  selector: 'app-viewbooking',
  templateUrl: './viewbooking.component.html',
  styleUrls: ['./viewbooking.component.css']
})
export class ViewbookingComponent implements OnInit {
  userId!:any;
  historydetails: any;
  airlineId: any;
  inventoryId: any;
  flightbookingId: any;
  airlinedetails: any;
  inventorydetails: any;

  constructor(private service: ManagebookflightService, private airlineservice: ManageairlineService, private inventoryservice: ManageinventoryService, private toastr: ToastrService, public activatedrout: ActivatedRoute) { }


  ngOnInit(): void {
    this.activatedrout.paramMap.subscribe((params) => this.userId = params.get('userId'));
    this.activatedrout.paramMap.subscribe((params) => this.airlineId = params.get('airlinesId'));
    this.activatedrout.paramMap.subscribe((params) => this.inventoryId = params.get('inventoryId'));
    this.activatedrout.paramMap.subscribe((params) => this.flightbookingId = params.get('flightBookingId'));

    this.service.GetBookingHistorybyPnr(this.flightbookingId).subscribe(
      (data) => {
        debugger;
        this.historydetails = data;
        console.log(this.historydetails)
      }
      );
    this.airlineservice.getAirlinebyId(this.airlineId).subscribe((data) => {
      debugger
      this.airlinedetails = data;
      console.log(this.airlinedetails)
    });
    this.inventoryservice.getInventorybyId(this.inventoryId).subscribe((data) => {
      debugger
      this.inventorydetails = data;
      console.log(this.inventorydetails);
    });
  }

}
