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

        public SQLFlightBookingRepository(FlightBookAppDBContext _context)
        {
            this.context = _context;
        }

        public bool BookFlightbyUser(FlightBooking bookingDetails)
        {
            try
            {
                foreach(var p in bookingDetails.Passengers.ToList())
                {
                    p.SeatCount = 1;
                }
                context.FlightBookingDetailssql.Add(bookingDetails);
                context.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public bool CancelBookingbyPnr(int pnrId)
        {
            

            try
            {
                FlightBooking flight = new FlightBooking();
                flight = context.FlightBookingDetailssql.Find(pnrId);
                DateTime currentDate = DateTime.Now;
                DateTime bookedDate = flight.BookedDate;
                TimeSpan timeSpan = currentDate - bookedDate;
                if (flight != null && timeSpan.TotalHours <= 24)
                {
                    context.FlightBookingDetailssql.Remove(flight);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public IEnumerable<FlightBooking> GetBookingHistoryByuserId(int userid, bool value)
        {
            //int uid = context.FlightBookingDetailssql.Where(a => a.UserId == userid).FirstOrDefault().UserId; ;
            return context.FlightBookingDetailssql.Where(a => a.UserId == userid);
        }


        public FlightBooking GetBookingInfoByPnr(int pnrId)
        {
            try
            {
                FlightBooking flight = new FlightBooking();
                flight = context.FlightBookingDetailssql.Find(pnrId);
                return flight;
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        //FlightBooking IFlightBookingRepository.BookFlightbyUser(FlightBooking bookingDetails)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
