// import { passengers } from '../model/managebookflight.model';
export class Manageinventory {
    InventoryId! : number;
    AirlinesId!:number;
    FlightNumber!:number;
    AirlinePrice!:number;
    AirlineTotalCost!:number;
    FromPlace:string='';
    ToPlace:string='';
    AirlineStartDate!:Date;
    AirlineEndDate!:Date;
    InstrumentUsed:string='';
    TotalBusinessClassSeats!:number;
    TotalNonBusinessClassSeats!:number;
    NoOfRows!:number;
    Meal:string='';
    
}
