using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PvSimulationApplication.Models.Entites;

namespace PvSimulationApplication.Models.Repositories
{
    class PhotovoltaicModuleRepository
    {
        private PvSimulationContext pvContext;

        public PhotovoltaicModuleRepository()
        {
            pvContext = new PvSimulationContext();
        }

        public List<PhotovoltaicModule> FindAll()
        {
            return pvContext.PhotovoltaicModules.ToList();
        }


    }
}
