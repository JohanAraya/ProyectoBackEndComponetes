using Datos.Configs;
using Microsoft.EntityFrameworkCore;
using Pojos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contextos
{
    public class Conexion : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }

        public DbSet<Match> Matches { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseCosmos(
           "https://petcupid-final.documents.azure.com:443/",
           "D6yBtTFVFbYI75K2g39qf6vS2RYDAJaCVKhoSuSmsFn30GABxOiIxTWc3cV2Pr8GqFpSZPleUCRIARbQ9w8l7g==",
           "petcupid-final"
           );

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UsuarioConfig());

        }
    }
}
