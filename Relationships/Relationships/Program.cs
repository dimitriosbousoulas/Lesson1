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
            // var lista = db.Employees;


            var pragma = from emp in db.Employees
                         from dsk in db.Desks
                         select new
                         {
                             Onoma = emp.Name,
                             Modelo = dsk.Title
                         };


            foreach (var item in pragma)
            {
                Console.WriteLine("{0,-14}{1,-14}",item.Onoma, item.Modelo);
            }




            //Noumero 1
            //foreach (var emp in lista)
            //{
            //    Console.WriteLine("{0,-15}", emp.Name);
            //    foreach (var desk in emp.Desks)
            //    {
            //        Console.WriteLine("\t{0}", desk.Title);
            //    }
            //}



            //foreach (var item in db.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //    foreach (var pro in item.Projects)
            //    {
            //        Console.WriteLine(pro.Title);
            //    }
            //}

            //var lista = db.Employees.Include("Card"); //EAGER LOADING SXIMATISA ENA MEGALO QUERRY
            //var lista = db.Employees.Include(x => x.Card);           //EAGER LOADING SXIMATISA ENA MEGALO QUERRY

            //var lista = db.Employees;

            //foreach (var emp in lista)
            //{
            //    Console.WriteLine("{0,-15}{1,-16}}",emp.Name,emp.Card.Title);
            //}



            //var lista = db.Employees.ToList();



            //foreach (var emp in lista)
            //{
            //    Console.WriteLine(emp.Name);
            //}

        }
    }
}
