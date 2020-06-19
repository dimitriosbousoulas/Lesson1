using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Relationships.Models
{
    public class Employee
    {

        public int Id { get; set; } // ( Id )  ( EmployeeId )   [Key]  -- Primary Key
        public string Name { get; set; }


    }
}
