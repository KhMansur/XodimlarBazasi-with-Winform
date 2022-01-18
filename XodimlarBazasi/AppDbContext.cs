using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XodimlarBazasi.Models;

namespace XodimlarBazasi
{
    public class AppDbContext : DbContext
    {
        public DbSet<Xodim> Xodimlar { get; set; }
    }
}
