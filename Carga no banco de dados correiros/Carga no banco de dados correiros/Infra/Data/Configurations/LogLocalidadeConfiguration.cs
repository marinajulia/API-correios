using Carga_no_banco_de_dados_correiros.Domain.Services.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carga_no_banco_de_dados_correiros.Infra.Data.Configurations
{
    class LogLocalidadeConfiguration : IEntityTypeConfiguration<LogLocalidade>
    {
        public void Configure(EntityTypeBuilder<LogLocalidade> builder)
        {
            builder.ToTable("LogLocalidade");
            builder.HasKey(p => p.LOC_NU);
            builder.Property(p => p.UFE_SG);
            builder.Property(p => p.LOC_NO);
            builder.Property(p => p.CEP);
            builder.Property(p => p.LOC_IN_SIT);
            builder.Property(p => p.LOC_IN_TIPO_LOC);
            builder.Property(p => p.LOC_NU_SUB);
            builder.Property(p => p.LOC_NO_ABREV);
            builder.Property(p => p.MUN_NU);
        }
    }
}
