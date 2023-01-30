using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Configuration
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Criterio> Criterio { set; get; }
        public DbSet<Familia> Familia { set; get; }
        public DbSet<Parentesco> Parentesco { set; get; }
        public DbSet<Pessoa> Pessoa { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            string strCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CasaPopular;Integrated Security=True;";

            //string strCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CasaPopular;Integrated Security=False;User ID=sa;Password=Passw0rd;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }

    }
}
