using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            int tempo = 10;
            int minutoAtual = 0;
            while (minutoAtual != tempo)
            {
               minutoAtual++;
               Console.WriteLine(minutoAtual);
            }
        }
        
    }
}