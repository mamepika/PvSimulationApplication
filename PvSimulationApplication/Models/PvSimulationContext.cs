using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PvSimulationApplication.Models.Entites;


namespace PvSimulationApplication.Models
{
    public class PvSimulationContext : DbContext
    {

        public DbSet<Metropolis> Metropolises { get; set; }

        public DbSet<City> Cities { get; set; }
    }
}