using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCassignment.Models
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base("name = Moviesdbss")
        {

        }
    public DbSet<Movie> movies { get; set; }
    }
}