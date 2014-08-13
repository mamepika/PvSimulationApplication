using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PvSimulationApplication.Models.Entites
{
    /// <summary>
    /// 都市情報のエンティティクラス
    /// </summary>
    [Table("Metropolises")]
    public class Metropolis
    {
        [Key]
        public string MetropolisId { get; set; }

        public string MetropolisName { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public override string ToString()
        {
            return this.MetropolisName;
        }
    }
}