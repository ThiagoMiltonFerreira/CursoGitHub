using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloGitHub
{
    class Program
    {
        static void EscreveNaTela(String txt)
        {
            Console.WriteLine(txt);
        }
        static void EscreveNaTela2(String txt)
        {
            EscreveNaTela2(txt);
        }
         static void EscreveNaTela3(String txt)
        {
            //aaaa
            EscreveNaTela2(txt);
        }

        static void Main(string[] args)
        { 
            EscreveNaTela("Ultima versao");
            EscreveNaTela("Primeiro Programa com GItHub 10:49");
            Console.ReadKey();

        }
    }
}
