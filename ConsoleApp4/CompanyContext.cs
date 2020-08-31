using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class DataContext : DbContext
    {

        public DataContext() : base("testdb")
        {

        }

        public DbSet<Company> Companies { get; set; }
    }
}