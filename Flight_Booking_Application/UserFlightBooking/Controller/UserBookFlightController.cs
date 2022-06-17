using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserFlightBooking.Model;
using UserFlightBooking.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserFlightBooking.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookFlightController : ControllerBase
    {
        private IFlightBookingRepository flights;
        private IConverter _converter;
        public UserBookFlightController(IFlightBookingRepository _flights, IConverter converter)
        {
            flights = _flights; _converter = converter;
        }
        

        // GET api/<UserBookFlightController>/5
        [HttpGet("{id}")]
        public FlightBooking Get(int id)
        {
            return flights.GetBookingInfoByPnr(id);
        }
        [HttpGet("{id}/{value}")]
        public IEnumerable<FlightBooking> Get(int id, bool value)
        {
            return flights.GetBookingHistoryByuserId(id, value);
        }

        // POST api/<UserBookFlightController>
        [HttpPost]
        [Route("bookFlight")]
        public IActionResult Post([FromBody] FlightBooking flightDetails)
        {
            flightDetails.BookedDate = DateTime.Now;
            return Ok(new { apiresponse = flights.BookFlightbyUser(flightDetails) });
        }

        // PUT api/<UserBookFlightController>/5
        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserBookFlightController>/5
        [HttpDelete("{id}")]
        //[Route("cancelBooking")]
        public IActionResult Delete(int id)
        {
            bool value = flights.CancelBookingbyPnr(id);
            if (value)
            {
                return Ok(new { apiresponse =value});
            }
            else
            {
                return Ok(new { apiresponse = value });
            }
        }
        //public string GetHTMLString(int pnr)
        //{
        //    //var employees = DataStorage.GetAllEmployess();
        //    FlightBooking flight = new FlightBooking();
        //    flight =  flights.GetBookingInfoByPnr(pnr);
        //    var sb = new StringBuilder();
        //    sb.Append(@"
        //                <html>
        //                    <head>
        //                    </head>
        //                    <body>
        //                        <div class='header'><h1>This is the generated PDF report!!!</h1></div>
        //                        <table align='center'>
        //                            <tr>
        //                                <th>Name</th>
        //                                <th>LastName</th>
        //                                <th>Age</th>
        //                                <th>Gender</th>
        //                            </tr>");

        //    //foreach (var emp in employees)
        //    //{
        //    sb.AppendFormat(@"<tr>
        //                            <td>{0}</td>
        //                            <td>{1}</td>
        //                            <td>{2}</td>
        //                            <td>{3}</td>
        //                          </tr>",
        //                      flight.MealOpted, flight.NoofSelctedBusinessclassSeats,flight.NoofSelctedNonBusinessclassSeats,flight.UserId);
        //    //}

        //    sb.Append(@"
        //                        </table>
        //                    </body>
        //                </html>");

        //    return sb.ToString();
        //}

        //[HttpGet("{pnr}/{value}")]
        //public IActionResult CreatePDF(int pnr,bool value)
        
        
        //{
        //    var globalSettings = new GlobalSettings
        //    {
        //        ColorMode = ColorMode.Color,
        //        Orientation = Orientation.Portrait,
        //        PaperSize = PaperKind.A4,
        //        Margins = new MarginSettings { Top = 10 },
        //        DocumentTitle = "PDF Report",
        //       // Out = @"D:\PDFCreator\Employee_Report.pdf"
        //    };
        //    var objectSettings = new ObjectSettings
        //    {
        //        PagesCount = true,
        //        HtmlContent = GetHTMLString(pnr),
        //        //WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
        //        HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
        //        FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
        //    };
        //    var pdf = new HtmlToPdfDocument()
        //    {
        //        GlobalSettings = globalSettings,
        //        Objects = { objectSettings }
        //    };
        //    var file =_converter.Convert(pdf);
        //    return File(file, "application/pdf");
        //    //return Ok("Successfully created PDF document.");
        //}
    }
}
