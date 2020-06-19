using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Relationships.Models;

namespace Relationships
{
    public class MyDatabase : DbContext    //Mporei na legetai ApplicationDbContext i opos allios thes
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Desk> Desks { get; set; }



    }
}
