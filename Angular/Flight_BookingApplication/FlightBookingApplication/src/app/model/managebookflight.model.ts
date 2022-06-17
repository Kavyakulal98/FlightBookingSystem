export class Managebookflight {
    FlightBookingId!:number;
    UserId!:number;
    AirlinesId!:number;
    InventoryId!:number;   
    BookedDate!:Date;
    amountPaid!:number;
    isdiscountApplied:boolean=false;
    passengers:passengersDetails[]=[];
}
export class passengersDetails{
    Id!:number;
    Name!:string;
    Gender!:string;
    Age!:number;
    FlightBookingId!:number;
    SeatNumber!:string;
    Seat!:string;
}
