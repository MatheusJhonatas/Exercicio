/*Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi aprovado 
se o valor da média escolar for maior ou igual a 7. 
Se o valor da média for menor que 7, solicitar a nota
do recuperação, somar com o valor da média e obter a nova média. 
Se a nova média for maior ou igual a 7,
apresentar uma mensagem informando que o aluno foi aprovado na recuperação. 

Se o aluno não foi aprovado,
apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
aluno.

meu código*/

using System;
namespace Exercicio_17
{
    public class Exercicio_17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota de Matematica: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota de Português: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota de Quimica: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nota de Fisica: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"Sua média é:  {media}");
            if (media >= 7)
            {
                Console.WriteLine("Você foi Aprovado!");
            }
            if (media < 7)
            {

                if (media <= 7)
                {
                    Console.WriteLine("Digite sua nota de recuperação: ");
                    double recuperacao = Convert.ToInt16(Console.ReadLine());
                    double somaRecuperacao = media + recuperacao;
                    if (somaRecuperacao >= 7)
                    {
                        Console.WriteLine("Você foi aprovado na Recuperação!");
                    }
                }
                else
                {
                    Console.WriteLine($"Você não foi aprovado sua média foi {media}");
                }
            }
        }
    }
}

/*Código do chatgpt

using System;

class Program
{
    static void Main()
    {
        // Solicita as quatro notas do aluno
        Console.WriteLine("Digite as quatro notas do aluno:");
        double nota1 = LerNota("Primeira nota: ");
        double nota2 = LerNota("Segunda nota: ");
        double nota3 = LerNota("Terceira nota: ");
        double nota4 = LerNota("Quarta nota: ");

        // Calcula a média das notas
        double media = CalcularMedia(nota1, nota2, nota3, nota4);
        Console.WriteLine($"A média do aluno é: {media}");

        // Verifica se o aluno foi aprovado
        if (media >= 7.0)
        {
            Console.WriteLine("O aluno foi aprovado!");
        }
        else
        {
            // Caso contrário, pede a nota da recuperação
            double notaRecuperacao = LerNota("Digite a nota da recuperação: ");
            double novaMedia = (media + notaRecuperacao) / 2;

            // Verifica se a nova média é suficiente para aprovação
            if (novaMedia >= 7.0)
            {
                Console.WriteLine($"O aluno foi aprovado na recuperação com média {novaMedia}");
            }
            else
            {
                Console.WriteLine($"O aluno não foi aprovado, com média final {novaMedia}");
            }
        }
    }

    // Função para ler uma nota válida do usuário
    static double LerNota(string mensagem)
    {
        double nota;
        do
        {
            Console.Write(mensagem);
        } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10);
        return nota;
    }

    // Função para calcular a média das notas
    static double CalcularMedia(double nota1, double nota2, double nota3, double nota4)
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }
}*/

