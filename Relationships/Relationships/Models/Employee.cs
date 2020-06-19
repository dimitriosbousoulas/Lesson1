using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationships.Models
{
    //One to One
    public class Employee
    {
      
        public int Id { get; set; } // ( Id )  ( EmployeeId )   [Key]  -- Primary Key
        public string Name { get; set; }
        public virtual Card Card { get; set; }  //Edo me virtual exo petixei lazy loading

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Desk> Desks { get; set; }



    }
}
