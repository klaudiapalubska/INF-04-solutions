namespace Sito_Erastotenesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            bool[] A = new bool[n + 1];

            Sito(A);
        }

 /********************************************************
 nazwa funkcji: Sito
 parametry wejściowe: A - tablica typu logicznego bool
 wartość zwracana: funkcja nie zwraca nic
 informacje: funkcja wykorzystuje algorytm sita erastotenesa i wypisuje liczby pierwsze na ekranie
 autor: XYZ
****************************************************/
        static void Sito(bool[] A)
        {
            int n = 100 - 1;
            Console.WriteLine("Liczby pierwsze:");
            for(int i = 2; i* i < n; i++)
            {
                if (!A[i]) {for (int j = i * i; j <= n; j += i)
                        A[j] = true;
                }
            }


            for (int i = 2; i <= n; i++)
            {
                if (!A[i]) 
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}