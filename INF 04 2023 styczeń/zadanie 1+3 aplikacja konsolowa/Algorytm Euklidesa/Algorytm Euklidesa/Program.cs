namespace Algorytm_Euklidesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź a:");
           string wartosc = Console.ReadLine();
            Console.WriteLine("Wprowadź b:");
            string wartosc2 = Console.ReadLine();
            int a = int.Parse(wartosc);
            int b= int.Parse(wartosc2);
            a = NWD(a, b);
            Console.WriteLine(a);

           
        }

        /*******
         * nazwa funkcji: NWD
         * opis funkcji: Funkcja liczy największy wspólny dzielnik
         * parametry: a - pierwsza wartosc zawierajaca tylko cyfry, b - druga wartosc zawierajaca tylko cyfry
         * zwracany typ i opis: int - zwraca wartosc a, która jest największy wspólnym dzielnikiem
         * autor: xyz
         ********/
        static int NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (a == b){
                    return a;
                }
                else
                {
                    b = b - a;
                }
               
            }
            return a;
        }
    }
}