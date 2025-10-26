using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Concesionaria.Models;

namespace Concesionaria.Data
{
    public class ConcesionariaContext : DbContext
    {
        public ConcesionariaContext (DbContextOptions<ConcesionariaContext> options)
            : base(options)
        {
        }

        public DbSet<Concesionaria.Models.Carro>? Carro { get; set; } = default!;
        public DbSet<Concesionaria.Models.Cliente>? Cliente { get; set; } = default!;
        public DbSet<Concesionaria.Models.Vendedor>? Vendedor { get; set; } = default!;
        public DbSet<Concesionaria.Models.Nota> Nota { get; set; } = default!;
    }
}
