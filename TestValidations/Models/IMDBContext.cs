using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestValidations.Models
{
    public class IMDBContext : DbContext
    {
        public IMDBContext() : base("name=IMDBConnection")
        {

        }
        public DbSet<IMDB> IMDBs { get; set; }
    }
}