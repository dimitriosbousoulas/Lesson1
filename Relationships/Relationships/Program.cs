using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            var lista = db.Employees.ToList();

            foreach (var emp in lista)
            {
                Console.WriteLine(emp.Name);
            }

        }
    }
}
