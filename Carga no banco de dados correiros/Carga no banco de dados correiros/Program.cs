using Carga_no_banco_de_dados_correiros.Domain.Services.Entidades;
using Carga_no_banco_de_dados_correiros.Infra.Data;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Carga_no_banco_de_dados_correiros
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastrarLocalidade();

        }

        private static void CadastrarLocalidade()
        {
            using var db = new ApplicationContext();

            string[] lines = File.ReadAllLines(@"C:\Users\Marina\source\repos\Arquivos Correios\eDNE_Basico\Delimitado\LOG_LOCALIDADE.TXT", Encoding.UTF7);

            List<LogLocalidade> localidades = new List<LogLocalidade>();

            foreach (var line in lines)
            {
                var loc = new LogLocalidade();
                var props = line.Split("@");

                loc.LOC_NU = Convert.ToInt32(props[0]);
                loc.UFE_SG = props[1];
                loc.LOC_NO = props[2];
                loc.CEP = props[3];
                loc.LOC_IN_SIT = props[4];
                loc.LOC_IN_TIPO_LOC = props[5];
                loc.LOC_NU_SUB = props[6];
                loc.LOC_NO_ABREV = props[7];
                loc.MUN_NU = props[8];
                localidades.Add(loc);

                //Console.WriteLine(props[0]);
                //Console.WriteLine(line);

            }
            db.BulkInsert(localidades);

        }
    }
}
