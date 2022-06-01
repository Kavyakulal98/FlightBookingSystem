using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFlightBooking.Model;

namespace UserFlightBooking.Repository
{
    public class SQLFlightBookingRepository : IFlightBookingRepository
    {
        private readonly FlightBookAppDBContext context;

        public SQLFlightBookingRepository(FlightBookAppDBContext _context)
        {
            this.context = _context;
        }
        public FlightBooking BookFlightbyUser(FlightBooking bookingDetails)
        {
            
            context.FlightBookingDetailssql.Add(bookingDetails);
            context.SaveChanges();
            //IEnumerable<PassengerDetails> passDetails;
            //passDetails = bookingDetails.Passengers;
            //foreach (var passenger in passDetails)
            //{
            //    passenger.Id = 0;
            //    passenger.FlightBookingId = bookingDetails.FlightBookingId;
            //    context.PassengerDetailssql.Add(passenger);
            //   context.SaveChanges();
            //}
            //context.SaveChanges();
            return bookingDetails;
        }

        public bool CancelBookingbyPnr(int pnrId)
        {
            FlightBooking flight = context.FlightBookingDetailssql.Find(pnrId);
            PassengerDetails passenger = context.PassengerDetailssql.Find(pnrId);
            if (flight != null)
            {
                context.FlightBookingDetailssql.Remove(flight);
                context.SaveChanges();
                if (passenger != null)
                {
                    context.PassengerDetailssql.Remove(passenger);
                    context.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //public IEnumerable<FlightBooking> GetBookingHistoryByUserId(int userId)
        //{
        //    throw new NotImplementedException();
        //}

        public FlightBooking GetBookingInfoByPnr(int pnrId)
        {
            FlightBooking flight = context.FlightBookingDetailssql.Find(pnrId);
           // IEnumerable<PassengerDetails> passDetails;
           // passDetails = context.PassengerDetailssql.Where(a => a.FlightBookingId == pnrId);
            //foreach (var passenger in passDetails)
            //{
               // flight.Passengers = passDetails;
            //}
                return flight;
        }
    }
}
