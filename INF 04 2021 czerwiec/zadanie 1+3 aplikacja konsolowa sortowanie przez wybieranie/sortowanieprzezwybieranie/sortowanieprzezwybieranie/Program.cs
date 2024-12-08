namespace sortowanieprzezwybieranie
{
    using System;

    public class Program
    {


        /********************************************************
       * nazwa funkcji: ZnajdzMaksymalnaWartosc
       * parametry wejściowe: tablica - tablica cyfr całkowitych
       * wartość zwracana: zwracana zostaje maksymalna cyfra z tablicy jako int
       * autor: xyz
       * ****************************************************/
        private static int ZnajdzMaksymalnaWartosc(int[] tablica)
        {
            int maksymalna = tablica[0]; 
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > maksymalna)
                {
                    maksymalna = tablica[i];
                }
            }
            return maksymalna;
        }

        /********************************************************
        * nazwa funkcji: SortujTablice
        * parametry wejściowe: tablica - tablica cyfr całkowitych
        * wartość zwracana: brak
        * autor: xyz
        * ****************************************************/
        public static void SortujTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                int indeksMin = i;
                for (int j = i + 1; j < tablica.Length; j++)
                {
                    if (tablica[j] < tablica[indeksMin])
                    {
                        indeksMin = j;
                    }
                }
                // Zamiana miejscami
                int temp = tablica[i];
                tablica[i] = tablica[indeksMin];
                tablica[indeksMin] = temp;
            }
        }

       
        public static void WyswietlTablice(int[] tablica)
        {
            foreach (var el in tablica)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] tablica = new int[10];
            Console.WriteLine("Wypisz dziesięć cyfr do posortowania");

            for (int i = 0; i < tablica.Length; i++)
            {
                string text = Console.ReadLine();

                tablica[i] = Convert.ToInt32(text);
            }
         
            SortujTablice(tablica);
            Console.WriteLine("Tablica po posortowaniu:");
            WyswietlTablice(tablica);

            
            int maksymalna = ZnajdzMaksymalnaWartosc(tablica);
            Console.WriteLine("Maksymalna wartość: " + maksymalna);
        }
    }




}
