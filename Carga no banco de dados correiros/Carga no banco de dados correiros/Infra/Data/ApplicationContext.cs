using Carga_no_banco_de_dados_correiros.Domain.Services.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carga_no_banco_de_dados_correiros.Infra.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TUN7NB2\SQLEXPRESS;Initial Catalog=Correios;Integrated Security=True");
        }

        public DbSet<LogLocalidade> LogLocalidade { get; set; }
    }
}
