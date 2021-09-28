using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MillingManagement.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DefaultConnection")
        {

        }

        public DbSet<Plant> Plants { get; set; }
    }
}