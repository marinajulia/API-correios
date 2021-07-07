using Carga_no_banco_de_dados_correiros.Domain.Services.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Carga_no_banco_de_dados_correiros.Infra.Data.Configurations
{
    class LogBairroConfiguration : IEntityTypeConfiguration<LogBairro>
    {
        public void Configure(EntityTypeBuilder<LogBairro> builder)
        {
            builder.ToTable("Logbairro");
            builder.HasKey(p => p.BAI_NU);
            builder.Property(p => p.UFE_SG);
            builder.Property(p => p.BAI_NO);
            builder.Property(p => p.BAI_NO_ABREV);
        }
    }
}
