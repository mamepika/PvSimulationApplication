using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PvSimulationApplication.Models.Entites
{
    /// <summary>
    /// 日射量のエンティティクラス
    /// </summary>
    [Table("SolarRadiations")]
    public class SolarRadiation
    {
        [Key]
        public Int64 SolarRadiationId { get; set; }
        
        public string CityId { get; set; }

        public int DirectionAngle { get; set; }

        public int InclineAngle { get; set; }

        public double January { get; set; }

        public double February { get; set; }

        public double March { get; set; }

        public double April { get; set; }

        public double May { get; set; }

        public double June { get; set; }

        public double July { get; set; }

        public double August { get; set; }

        public double September { get; set; }

        public double October { get; set; }

        public double November { get; set; }

        public double December { get; set; }
        
        public virtual City city { get; set; }
    }
}