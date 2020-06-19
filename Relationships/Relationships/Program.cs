using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();



            //var lista = db.Employees.Include("Card"); //EAGER LOADING SXIMATISA ENA MEGALO QUERRY
            //var lista = db.Employees.Include(x => x.Card);           //EAGER LOADING SXIMATISA ENA MEGALO QUERRY

            var lista = db.Employees;

            foreach (var emp in lista)
            {
                Console.WriteLine("{0,-15}",emp.Name);
            }
            
            
            
            //var lista = db.Employees.ToList();



            //foreach (var emp in lista)
            //{
            //    Console.WriteLine(emp.Name);
            //}

        }
    }
}
