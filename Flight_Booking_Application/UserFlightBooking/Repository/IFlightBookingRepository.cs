using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFlightBooking.Model;

namespace UserFlightBooking.Repository
{
   public interface IFlightBookingRepository
    {
        FlightBooking GetBookingInfoByPnr(int pnrId);
       // IEnumerable<FlightBooking> GetBookingHistoryByUserId(int userId);

        FlightBooking BookFlightbyUser(FlightBooking bookingDetails);
        bool CancelBookingbyPnr(int pnrId);
    }
}
