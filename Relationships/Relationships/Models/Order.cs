using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships.Models
{
    public class Order //ProductEmployees
    {
        public virtual Product Product { get; set; }
        public virtual Employee Employee { get; set; }


        [Key, Column(Order = 1)]
        public int EmployeeId { get; set; }
        [Key, Column(Order = 2)]
        public int ProductId { get; set; }


        public DateTime OrderedDate { get; set; }
        public int Price { get; set; }


    }
}
