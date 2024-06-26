/*Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). 

Verificar se cada lado é menor que a soma dos outros dois lados. 

Se sim, saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero; 

Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; 
e caso contrário, o triângulo será escaleno. 
Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os três lados do triângulo:");

        // Entrada dos lados do triângulo
        Console.Write("Lado A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        // Verificação se os lados formam um triângulo
        if (VerificaTriangulo(ladoA, ladoB, ladoC))
        {
            // Verificação do tipo de triângulo
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os lados fornecidos não formam um triângulo.");
        }
    }

    // Função para verificar se os lados formam um triângulo
    static bool VerificaTriangulo(double a, double b, double c)
    {
        return (a + b > c) && (b + c > a) && (c + a > b);
    }
}
