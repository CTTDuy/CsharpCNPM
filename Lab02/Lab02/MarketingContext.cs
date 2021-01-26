using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class MarketingContex:DbContext
    {
        public DbSet<Phone> phones { get; set; }
        public DbSet<Manufacture> manufactures { get; set; }
    }
}
