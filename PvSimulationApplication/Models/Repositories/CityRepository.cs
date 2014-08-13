using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PvSimulationApplication.Models.Entites;

namespace PvSimulationApplication.Models.Repositories
{
    public class CityRepository
    {
        private PvSimulationContext pvContext;

        public CityRepository()
        {
            pvContext = new PvSimulationContext();
        }
        public List<City> FindAll()
        {
            return pvContext.Cities.ToList();
        }

        public List<City> FindByMetroPolisId(string metropolisId)
        {
            return pvContext.Cities.Where(city => city.MetropolisId == metropolisId).ToList();
        }

    }
}
