using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships.Models
{
    public class Card
    {

        [ForeignKey("Employee")]
        public int CardId { get; set; } //Ayto tha ginei primary key
        public string Title { get; set; }

        public virtual Employee Employee { get; set; }  //Edo me virtual exo petixei lazy loading

    }
}
