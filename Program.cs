using System;

namespace sequencia_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1 = 0;
            int Numero2 = 1;
            int NumeroDoUsuario;
            int Result;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.Write("Digite a quantidade de termos: ");
            NumeroDoUsuario = Convert.ToInt32(Console.ReadLine());
            
            Console.ResetColor();

            Console.WriteLine();

            Result = Numero1 + Numero2;

            Console.Write(0 + " " + 1 + " ");

            int i = 3;

            while (i <= NumeroDoUsuario)
            {
                i ++;
                Console.Write(Result + " ");
                Numero1 = Numero2;
                Numero2 = Result;
                Result = Numero1 + Numero2;
            }
        }
    }
}