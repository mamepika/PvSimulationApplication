using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PvSimulationApplication.Models.Entites
{
    /// <summary>
    /// 市町村情報のエンティティクラス
    /// </summary>
    public class City
    {
        
        public string CityId { get; set; }
        [Required]
        public string MetropolisId { get; set; }
        [Required]
        public string CityName { get; set; }
        [ForeignKey("MetropolisId")]
        public virtual Metropolis metropolis { get; set; }

        public override string ToString()
        {
            return this.CityName;
        }
    }
}