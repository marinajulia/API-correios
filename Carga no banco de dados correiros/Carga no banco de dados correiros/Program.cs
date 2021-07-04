using System;
using System.IO;
using System.Text;

namespace Carga_no_banco_de_dados_correiros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("LOG_LOCALIDADE.TXT", Encoding.UTF7);

            foreach (var line in lines)
            {
                var props = line.Split("@");
                //Console.WriteLine(props[0]);
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
