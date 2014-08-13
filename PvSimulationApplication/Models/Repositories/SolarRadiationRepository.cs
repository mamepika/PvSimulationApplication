using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PvSimulationApplication.Models.Entites;

namespace PvSimulationApplication.Models.Repositories
{
    public class SolarRadiationRepository : ISolarRadiationRepository
    {

        private PvSimulationContext pvSimulationContext;

        public SolarRadiationRepository()
        {
            pvSimulationContext = new PvSimulationContext();
        }


        public List<SolarRadiation> FindAll()
        {
           return pvSimulationContext.SolarRadiations.ToList();
        }

        public SolarRadiation FindByIdAndAngle(string cityId, int direction, int incline)
        {
            return pvSimulationContext.SolarRadiations
                        .Where(x => x.CityId == cityId)
                        .Where(x => x.DirectionAngle == direction)
                        .Where(x => x.InclineAngle == incline).First<SolarRadiation>();
        }



        public void Add(SolarRadiation ladiation)
        {
            pvSimulationContext.SolarRadiations.Add(ladiation);
        }

        public void Save()
        {
            pvSimulationContext.SaveChanges();
            
        }

        public void Dispose()
        {
            pvSimulationContext.Dispose();
        }
    }
}
