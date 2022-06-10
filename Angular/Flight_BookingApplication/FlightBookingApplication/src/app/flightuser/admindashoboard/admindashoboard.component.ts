
import { Component, Injectable, OnInit } from '@angular/core';
import { Manageairline } from 'src/app/model/manageairline.model';
import { ManageairlineService } from 'src/app/service/manageairline.service';
import { map, Observable } from 'rxjs';
import { HttpClient,HttpParams,HttpHeaders } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-admindashoboard',
  templateUrl: './admindashoboard.component.html',
  styleUrls: ['./admindashoboard.component.css']
})
@Injectable()
export class AdmindashoboardComponent implements OnInit {
  listAirliness: Array<any>=[];
  constructor(public service:ManageairlineService,private toastr:ToastrService) { }

  ngOnInit() {
    debugger
     this.service.getAllAirline().subscribe((data)=>this.listAirliness = data);
  }
  BlockAirline(data:Manageairline){
    // const airlinevalues = this.AirlineForm.value;
data.IsBlocked=true;
    this.service.blockAirline(data).subscribe(
      (response)=>{
          this.toastr.success("blocked successfully"); 
          this.service.getAllAirline().subscribe((data1)=>this.listAirliness = data1);
      }
    );
   
  }

}
