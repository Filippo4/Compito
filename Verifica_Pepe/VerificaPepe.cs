using System;

namespace Verifica_Pepe
{
    public class VerificaPepe
    {
        public static void Max()
        {
            Console.WriteLine("inserisci il valore a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il valore b :");
            int b = int.Parse(Console.ReadLine());
            int Max = Math.Max(a, b);
            Console.WriteLine($"il più grande è {Max}");
        }

        public static void Media()
        {
            Console.WriteLine("inserisci il valore a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il valore b :");
            double b = double.Parse(Console.ReadLine());
            double media = (a + b) / 2;
            Console.WriteLine($"la media è {media}");
        }

        public static void Scambio(ref uint a, ref uint b)
        {
            uint c = a;
            a = b;
            b = c;
            Console.WriteLine($"{c} , {b}");
        }

        public static int Conta()
        {
            int a = 0;
            int conta = 0;
            do
            {
                Console.WriteLine("inserisci un numero");
                a = int.Parse(Console.ReadLine());
                if (a != 0)
                    conta++;
            } while (a != 0);
            return conta;
        }
        public static int SommaRicorsiva(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + SommaRicorsiva(n - 1);
        }

        public static double Operazioni (double a , double b, char op)
        {
            double risultato = 0 ;
            switch(op)
            {
                case '+':
                     risultato = a + b;
                    break;
                case '-':
                     risultato = a - b;
                    break;
                case '*':
                     risultato = a * b;
                    break;
                case '/':
                    if (a == 0)
                        throw new Exception("la divisione è impossibile!");
                    else
                        risultato = a / b;
                    break;
                default:
                    throw new Exception("non hai inserito nessun numero ");
            }
            return risultato;
        }

        public static double Operazioni2()
        {
            char c;
            double risposta;
            do
            {
                Console.WriteLine("inserisci il primo numero!");
                double a = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci il secondo numero!");
                double b = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci il carattere!");
                c = Console.ReadLine()[0];
                risposta = Operazioni(a, b, c);
                
            } while (c != 'q');
            return risposta;
        }
        public static int  Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        public static void StampaFibonacci(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.WriteLine(Fibonacci(i) + " ");
        }
    }
}
