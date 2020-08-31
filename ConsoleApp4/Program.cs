using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new DataContext();
            List<Company> companies = ctx.Companies.ToList();
            foreach (Company comp in companies)
            {
                Console.WriteLine($"{comp.CompanyName}");
            }
        }
    }


}
