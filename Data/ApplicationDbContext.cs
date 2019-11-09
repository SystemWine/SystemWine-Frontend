using System;
using System.Collections.Generic;
using System.Text;
using Frontend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace frontend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<TipoUva> TiposUva { get; set; }
        public DbSet<UsuarioPreferencia> UsuariosPreferencia { get; set; }
        public DbSet<Vinho> Vinhos { get; set; }
        public DbSet<UsuarioNotaVinho> UsuariosNotaVinhos { get; set; }
        public DbSet <TipoVinho> TipoVinho { get; set; }

    }
}
