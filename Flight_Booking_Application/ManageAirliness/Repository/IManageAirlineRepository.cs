using ManageAirliness.Model;
using Microsoft.AspNetCore.Mvc;
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

        bool InsertAirline(Airlines airline);

        bool DeleteAirlines(int id);

        bool BlockAirlines(Airlines blockedAirline);
        //  int GetAirlineByName(int id);

    }
}
