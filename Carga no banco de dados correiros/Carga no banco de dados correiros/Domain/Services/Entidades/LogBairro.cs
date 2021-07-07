using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carga_no_banco_de_dados_correiros.Domain.Services.Entidades
{
    public class LogBairro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAI_NU { get; set; }

        [Column(TypeName = "char(2)")]
        public string UFE_SG { get; set; }

        public int LogLocalidadeId { get; set; }
        public LogLocalidade LogLocalidade { get; set; }

        [Column(TypeName = "varchar(72)")]
        public string BAI_NO { get; set; }

        [Column(TypeName = "varchar(36)")]
        public string BAI_NO_ABREV { get; set; }


    }
}
