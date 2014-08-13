using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PvSimulationApplication.Models.Entites;

namespace PvSimulationApplication.Models.Repositories
{
    public class MetropolisRepository
    {
        private PvSimulationContext pvContext;

        public MetropolisRepository()
        {
            pvContext = new PvSimulationContext();
        }

        public List<Metropolis> FindAll()
        {
            return pvContext.Metropolises.ToList();
        }
    }
}
