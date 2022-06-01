using ManageAirliness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirliness.Repository
{
    public interface IManageAirlineRepository
    {
        Airlines GetAirlinebyFlightId(int id);
        IEnumerable<Airlines> GetAllAirlines();

        Airlines InsertAirline(Airlines airline);

        bool DeleteAirlines(int id);

        bool BlockAirlines(Airlines blockedAirline);
        //  int GetAirlineByName(int id);

    }
}
