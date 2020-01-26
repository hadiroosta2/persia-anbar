using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace persia_anbar
{
    class dataBaseContex:DbContext
    {
        public dataBaseContex():base("name=dbPath")
        {

        }
        public DbSet<person> persons { get; set; }
        public DbSet<good> goods { get; set; }
        public DbSet<unit> units { get; set; }
        public DbSet<anbar> anbars { get; set; }
        public DbSet<car> cars { get; set; }
        public DbSet<tell> tells { get; set; }
        public DbSet<user> users { get; set; }
    }
}
