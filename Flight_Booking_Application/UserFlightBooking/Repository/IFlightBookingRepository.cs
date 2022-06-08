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
      // IEnumerable<FlightBooking> GetBookingHistoryByEmailId(string emailId,bool value);

        FlightBooking BookFlightbyUser(FlightBooking bookingDetails);
        bool CancelBookingbyPnr(int pnrId);
    }
}
