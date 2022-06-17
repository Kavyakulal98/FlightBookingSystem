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
       IEnumerable<FlightBooking> GetBookingHistoryByuserId(int userId,bool value);

        bool BookFlightbyUser(FlightBooking bookingDetails);
        bool CancelBookingbyPnr(int pnrId);
    }
}
