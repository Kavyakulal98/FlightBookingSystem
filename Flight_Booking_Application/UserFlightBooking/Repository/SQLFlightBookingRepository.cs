//using ManageAirliness.Model;
//using ManageAirliness.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFlightBooking.Model;
//using UserManagement.Repository;
//using UserManagement.Model;

namespace UserFlightBooking.Repository
{
    public class SQLFlightBookingRepository : IFlightBookingRepository
    {
        private readonly FlightBookAppDBContext context;
        //private readonly UserAppDBContext usercontext;
       // private readonly AppDBContext airlinecontext; 
        public SQLFlightBookingRepository(FlightBookAppDBContext _context)
        {
            this.context = _context;
            // this.airlinecontext = _airlinecontext;, AppDBContext _airlinecontext
            //this.usercontext = _usercontext; , UserAppDBContext _usercontext
        }

        public FlightBooking BookFlightbyUser(FlightBooking bookingDetails)
        {
            
            context.FlightBookingDetailssql.Add(bookingDetails);
            context.SaveChanges();
           // Inventory bookedInventory = context.Find(bookingDetails.InventoryId);
            //Inventory invDetails = new Inventory
            //{
            //    InventoryId = bookingDetails.InventoryId,
            //    TotalNonBusinessClassSeats = (bookedInventory.TotalNonBusinessClassSeats - bookingDetails.NoofSelctedBusinessclassSeats),
            //    TotalBusinessClassSeats = (bookedInventory.TotalBusinessClassSeats - bookingDetails.NoofSelctedBusinessclassSeats),
            //};
            //context.InventoryofAirlines.Attach(invDetails);
            //context.Entry(invDetails).Property(a => a.TotalBusinessClassSeats).IsModified = true;
            //context.Entry(invDetails).Property(a => a.TotalNonBusinessClassSeats).IsModified = true;
            //context.SaveChanges();
            return bookingDetails;
        }

        public bool CancelBookingbyPnr(int pnrId)
        {
            FlightBooking flight = context.FlightBookingDetailssql.Find(pnrId);
            //PassengerDetails passenger = context.PassengerDetailssql.Find(pnrId);
            DateTime currentDate = DateTime.Now;
            DateTime bookedDate=flight.BookedDate;
            TimeSpan timeSpan = currentDate - bookedDate;
            if (flight != null && timeSpan.TotalHours <=24)
            {
                context.FlightBookingDetailssql.Remove(flight);
                context.SaveChanges();
                //if (passenger != null)
                //{
                //    context.PassengerDetailssql.Remove(passenger);
                //    context.SaveChanges();
                //}
                return true;
            }
            else
            {
                return false;
            }
        }

        //public IEnumerable<FlightBooking> GetBookingHistoryByEmailId(string emailId,bool value)
        //{
        //    int uid = usercontext.User.Where(a => a.EmailAddress == emailId).FirstOrDefault().UserId; ;
        //    IEnumerable<FlightBooking>  flightHistory = context.FlightBookingDetailssql.Where(a => a.UserId == uid);
        //        return flightHistory;
        //}


        public FlightBooking GetBookingInfoByPnr(int pnrId)
        {
            FlightBooking flight = context.FlightBookingDetailssql.Find(pnrId);
           //flight.Passengers = context.PassengerDetailssql.Where(a=>a.FlightBookingId == pnrId).ToList();

            return flight;
        }
    }
}
