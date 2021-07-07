using Correios.Domain.Services.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Correios.Infra.Data
{

    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TUN7NB2\SQLEXPRESS;Initial Catalog=CorreiosDDD;Integrated Security=True");
        }

        public DbSet<LogLocalidade> LogLocalidade { get; set; }
    }
}

