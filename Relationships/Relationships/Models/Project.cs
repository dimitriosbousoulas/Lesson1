using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Relationships.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }


        public virtual Employee Employee { get; set; }


    }

    
   
    
}
