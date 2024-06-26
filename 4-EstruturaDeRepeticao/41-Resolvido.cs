/*41) Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias:
- Infantil A = 5 a 7 anos
- Infantil B = 8 a 11 anos
- Juvenil A = 12 a 13 anos
- Juvenil B = 14 a 17 anos
- Adultos = Maiores de 18 anos

Meu código:*/
using System;
namespace Exercicio41
{
    public class Exercicio41
    {
        public static void Main()
        {
            char encerrar = 'N';
            do
            {
                Console.WriteLine("Digite a idade do nadador:");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine();
                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Nadador é da categoria Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Nadador é da categoria Infantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Nadador é da categoria Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("O nadador é da categoria Juvenal B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Nadador é da categoria Adulto");
                }
                else
                {
                    Console.WriteLine("Você tem menos que 5 anos e por isso não tem categoria.");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                encerrar = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (encerrar != 'S');
        }
    }
}
