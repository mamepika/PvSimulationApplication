using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvSimulationApplication.Models.Entities
{
    public class PhotovoltaicModule
    {
        public int moduleId { get; set; }

        public string moduleName { get; set; }

        public int generatingPower { get; set; }
    }
}
