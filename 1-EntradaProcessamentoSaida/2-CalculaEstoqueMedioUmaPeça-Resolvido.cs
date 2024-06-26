/*Faça um programa para calcular o estoque médio de uma peça, sendo que:
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

MEU CÓDIGO>*/
using System;
using System.Xml;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Calcule o estoque médio de uma peça > \n");

                Console.WriteLine("Digite a quantidade minima do estoque :\n");
                int quantidade_minima = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade máxima: \n");
                int quantidade_maxima = int.Parse(Console.ReadLine());
                double Estoque_medio = quantidade_minima + quantidade_maxima / 2;
                Console.WriteLine($"O estoque médio de uma peça é: {Estoque_medio}");

            }
            catch
            {
                Console.WriteLine("Ops, deu algo errado, você precisa digitar somente números");
                Thread.Sleep(5000);
                Console.Clear();
                Main();

            }
        }
    }
}

/*CÓDIGO DO CHAT GPT>
using System;

class Program
{
    static void Main()
    {
        // Solicita a entrada do usuário para as quantidades mínima e máxima
        Console.WriteLine("Digite a quantidade mínima:");
        int quantidadeMinima = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade máxima:");
        int quantidadeMaxima = Convert.ToInt32(Console.ReadLine());

        // Calcula o estoque médio
        double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;

        // Exibe o resultado para o usuário
        Console.WriteLine($"O estoque médio é: {estoqueMedio}");

        Console.ReadLine(); // Espera o usuário pressionar Enter para sair
    }
}


PEDI PARA O CHAT GPT MELHORAR MEU CÓDIGO!

using System;

namespace EstoqueMedio
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Calcule o estoque médio de uma peça:\n");

                Console.WriteLine("Digite a quantidade mínima do estoque:");
                int quantidadeMinima;
                while (!int.TryParse(Console.ReadLine(), out quantidadeMinima))
                {
                    Console.WriteLine("Por favor, digite um número válido para a quantidade mínima:");
                }

                Console.WriteLine("Digite a quantidade máxima:");
                int quantidadeMaxima;
                while (!int.TryParse(Console.ReadLine(), out quantidadeMaxima))
                {
                    Console.WriteLine("Por favor, digite um número válido para a quantidade máxima:");
                }

                double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;
                Console.WriteLine($"O estoque médio de uma peça é: {estoqueMedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ops, algo deu errado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Pressione Enter para sair.");
                Console.ReadLine();
            }
        }
    }
}*/

