﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Carga_no_banco_de_dados_correiros.Domain.Services.Entidades
{
    public class LogLocalidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOC_NU { get; set; }

        [Column(TypeName = "char(2)")]
        public char UFE_SG { get; set; }

        [Column(TypeName = "varchar(72)")]
        public string LOC_NO { get; set; }

        [Column(TypeName = "char(8)")]
        public char CEP { get; set; }

        [Column(TypeName = "char(1)")]
        public char LOC_IN_SIT { get; set; }

        [Column(TypeName = "char(1)")]
        public char LOC_IN_TIPO_LOC { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string LOC_NU_SUB { get; set; }

        [Column(TypeName = "varchar(36)")]
        public string LOC_NO_ABREV { get; set; }

        [Column(TypeName = "char(7)")]
        public char MUN_NU { get; set; }
    }
}
