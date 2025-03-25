using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T6_P_EntityFrameworkCore.Data;

namespace T6_P_EntityFrameworkCore
{
    public partial class PanaderiaContext : DbContext
    {
        public PanaderiaContext()
        {
        }

        public PanaderiaContext(DbContextOptions<PanaderiaContext> options) : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Panaderia;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
