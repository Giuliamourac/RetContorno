using System;

public class Contorno
{
    public static void Main(string[] args)
    {
        int largura = 0;
        int altura = 0;

        Console.WriteLine("Vamos fazer o contorno de um retangulo, pressione uma tecla para prosseguirmos.");
        Console.ReadKey();

        Console.Write("Digite um valor para a altura:");
        altura = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Digite um valor para a largura:");
        largura = Convert.ToInt32(Console.ReadLine()!);

        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < largura; j++)
            {
                if ( i == 0 || j == 0  || i == altura - 1 || j == largura - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            
            Console.WriteLine();
        }
    }
}