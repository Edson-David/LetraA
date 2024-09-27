using System;

namespace LetraA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine();
           
            texto = texto.ToLower();

            int letraA = 0;
                        
            foreach (char caractere in texto)
            {
                if (caractere == 'a')
                {
                    letraA++;
                }
            }

            if (letraA > 0)
            {
                Console.WriteLine( "A letra 'a' aparece " + letraA + " vezes na string." );
            }
            else
            {
                Console.WriteLine( "A letra 'a' não foi encontrada na string." );
            }
        }
    }
}