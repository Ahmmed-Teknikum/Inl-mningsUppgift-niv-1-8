using System;

namespace InlämningsUppgift_._nivå1_._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int produkt = 1;

            for( int i = 1;i <= 5;i++ )
            {
                produkt *= i;
            }
            Console.WriteLine("Produkten av heltalen 1 till 5 är " + produkt);
        } 
    }
}