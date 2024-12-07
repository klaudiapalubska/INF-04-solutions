namespace egzaminzadanko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź numer PESEL");
            int[] pesel = new int[11];
            for (int i = 0; i < pesel.Length; i++)
            {
                Console.WriteLine("Wprowadź " + i + " numer peselu");
          int.TryParse(Console.ReadLine(), out pesel[i]) ;
            }
           
            char plec = Plec(pesel);
            if (plec == 'K') Console.WriteLine("Kobieta"); else Console.WriteLine("Mężczyzna");
            bool sumakontrolna = SumaKontrolna(pesel);
            if(sumakontrolna == true)  Console.WriteLine("Suma kontrolna jest zgodna"); else Console.WriteLine("Suma kontrolna jest niezgodna");



        }

 /***********************************************
nazwa funkcji: Plec
opis funkcji: Funkcja sprawdza płeć na podstawie peselu
parametry: x - tablica znaków 
zwracany typ i opis: zwracany typ znakowy określający płeć
autor: xyz
************************************************/
        static char Plec(int[] x)
        {
            char plecPesel;
            if (x[9] % 2 == 0) {
                plecPesel = 'K';
            }else { plecPesel = 'M'; }
            return plecPesel;
        }

        static bool SumaKontrolna(int[] pesel)
        {

            int s = 0;
           


            for (int i = 0; i < pesel.Length; i++)
            {
                if (i == 1 || i == 5 || i == 9)
                {
                    pesel[i] = pesel[i] * 3;
                }
                if (i == 2 || i == 6)
                {
                    pesel[i] = pesel[i] * 7;
                }
                if (i == 3 || i == 7)
                {
                    pesel[i] = pesel[i] * 9;
                }

                s += pesel[i];
            }

            int m = s % 10;
            int r;
            if (m == 0) r = 0; else r = 10 - m;
            if (r == pesel[10]) return true; else return false;

    
           
           
        }


    }
}