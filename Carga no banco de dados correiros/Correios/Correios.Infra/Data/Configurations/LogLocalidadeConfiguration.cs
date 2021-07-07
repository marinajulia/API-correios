using Correios.Domain.Services.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Correios.Infra.Data.Configurations
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
