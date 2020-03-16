using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ObrasBibliograficasAPI.Models
{
    public class ObrasBibliograficasAPIContext : DbContext
    {
        public ObrasBibliograficasAPIContext (DbContextOptions<ObrasBibliograficasAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ObrasBibliograficasAPI.Models.ObrasBibliograficas> ObrasBibliograficas { get; set; }


        protected override void OnModelCreating(ModelBuilder builder) {

            builder.Entity<ObrasBibliograficas>()
                .HasData(new List<ObrasBibliograficas>() {
                    new ObrasBibliograficas(1, "Marcelo da Silva Sousa"),
                    new ObrasBibliograficas(2, "João da Silva"),
                    new ObrasBibliograficas(3, "Paulo Coelho"),
                    new ObrasBibliograficas(4, "Celso de Araujo"),
                    new ObrasBibliograficas(5, "Guimaraes"),
                    new ObrasBibliograficas(6, "Roberto Ferreira Neto"),
                    new ObrasBibliograficas(7, "Anderson Gomes Souza Filho"),
                    new ObrasBibliograficas(8, "Matheus Alves"),
                    new ObrasBibliograficas(9, "Amanda Lima"),
                    new ObrasBibliograficas(10, "Isabela Feranandes Rocha"),
                    new ObrasBibliograficas(11, "Vinicius Matheus da Silva Neto"),
                    new ObrasBibliograficas(12, "Rafael Bezerra de Santos"),
                    new ObrasBibliograficas(13, "Ingrid"),
                    new ObrasBibliograficas(14, "Daniela Costa Filha"),
                    new ObrasBibliograficas(15, "Guilherme Borges de Souza"),
                    new ObrasBibliograficas(16, "Fernando"),
                    new ObrasBibliograficas(17, "Karina de Gomes"),
                    new ObrasBibliograficas(18, "Gisele Ferreira Santos")
                });
        }
    }
}
