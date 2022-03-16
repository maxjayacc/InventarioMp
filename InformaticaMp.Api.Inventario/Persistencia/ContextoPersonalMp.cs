using InformaticaMp.Api.Inventario.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformaticaMp.Api.Inventario.Persistencia
{
    public class ContextoPersonalMp : DbContext
    {
        public ContextoPersonalMp(DbContextOptions<ContextoPersonalMp> options) : base(options) { }
        public DbSet<PersonalMp> PersonalMp { get; set; }
        public DbSet<BienInformatico> BienInformatico { get; set; }

    }
}
