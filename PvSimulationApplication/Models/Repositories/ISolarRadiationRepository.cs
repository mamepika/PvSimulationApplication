using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PvSimulationApplication.Models.Entites;

namespace PvSimulationApplication.Models.Repositories
{
    interface ISolarRadiationRepository : IDisposable
    {
        List<SolarRadiation> FindAll();

        SolarRadiation FindByIdAndAngle(string cityId, int direction, int incline);

        void Add(SolarRadiation radiation);

        void Save();
    }
}
