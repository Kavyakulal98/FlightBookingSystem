import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { Manageinventory } from 'src/app/model/manageinventory.model';
import { ManageinventoryService } from 'src/app/service/manageinventory.service';

@Component({
  selector: 'app-inventorydashboard',
  templateUrl: './inventorydashboard.component.html',
  styleUrls: ['./inventorydashboard.component.css']
})
export class InventorydashboardComponent implements OnInit {
  airlinesId!:any;
  listInventory: Array<any>=[];
  constructor(private service:ManageinventoryService,private activatedrout:ActivatedRoute) { }

  ngOnInit(): void {
    debugger
    this.activatedrout.paramMap.subscribe((params)=>this.airlinesId=params.get('id'));
    debugger
    this.service.getAllInventory(this.airlinesId,true).subscribe(
      (data)=>
    {this.listInventory = data,
    console.log(data);
  });
  }

}
