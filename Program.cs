using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_010623
{
    class Program
    {
        static void Main(string[] args)
        {
            string PrimeiroNome;
            int Ano;
            string Profissão;
            
            Console.WriteLine("Bem-vindo ao cadastro de currículo");

            Console.WriteLine("Para começar, digite o seu primeiro nome:");
            PrimeiroNome = Console.ReadLine();

            Console.WriteLine("Digite o ano que você nasceu:");
            Ano = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua profissão:");
            Profissão = Console.ReadLine();

            Console.WriteLine("Cadastro realizado com sucesso!\n");

            Console.WriteLine($"Você se chama {PrimeiroNome} e tem {2023 - Ano} anos");
            Console.WriteLine($"Vagas para: {Profissão}");




            Console.ReadLine();

        }
    }
}
