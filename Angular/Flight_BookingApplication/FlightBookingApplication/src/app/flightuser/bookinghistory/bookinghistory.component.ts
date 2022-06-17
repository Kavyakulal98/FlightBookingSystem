import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Manageairline } from 'src/app/model/manageairline.model';
import { Managebookflight } from 'src/app/model/managebookflight.model';
import { Manageinventory } from 'src/app/model/manageinventory.model';
import { ManageairlineService } from 'src/app/service/manageairline.service';
import { ManagebookflightService } from 'src/app/service/managebookflight.service';
import { ManageinventoryService } from 'src/app/service/manageinventory.service';


@Component({
  selector: 'app-bookinghistory',
  templateUrl: './bookinghistory.component.html',
  styleUrls: ['./bookinghistory.component.css']
})
export class BookinghistoryComponent implements OnInit {

  historydetails: Array<any> = [];
  passengers: Array<any> = [];
  airlinedetails: Array<any> = [];;
  inventoryDetails: any;
  apiresponce: boolean = false;
  userId!: any;
  constructor(private service: ManagebookflightService, private airlineservice: ManageairlineService, private inventoryservice: ManageinventoryService, private toastr: ToastrService, public activatedrout: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedrout.paramMap.subscribe((params) => this.userId = params.get('userId'));

    this.service.GetBookingHistory(this.userId).subscribe(
      (data) => {
        debugger;
        this.historydetails = data;
        console.log(this.historydetails)
      }
      );
    this.airlineservice.getAllAirline().subscribe((data) => {
      debugger
      this.airlinedetails = data;
      console.log(this.airlinedetails)
    });
  }
  cancelBooking(id: number) {
    this.service.CancelBooking(id).subscribe((data) => {
      this.apiresponce = data.apiresponse;
      if (this.apiresponce == true) {
        this.toastr.success("Cancelled successfully");
      } else {
        this.toastr.error("Only ticket Booked within 24hours can be cancelled");
      }
    });
  }
  // this.airlineservice.getAirlinebyId(this.historydetails.AirlinesId).subscribe(
  //   (adata)=>this.airlinedetails = adata);
  //   this.inventoryservice.getInventorybyId(this.historydetails.UserId).subscribe(
  //     (idata)=>this.inventoryDetails = idata);

}
