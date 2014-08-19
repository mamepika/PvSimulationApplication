using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PvSimulationApplication.Models.Entites
{
    [Table("PhotovoltaicModules")]
    public class PhotovoltaicModule
    {
        [Key]
        public string moduleId { get; set; }

        public string moduleName { get; set; }

        public int generatingPower { get; set; }


        public override string ToString()
        {
            return this.moduleName;
        }
    }
}
