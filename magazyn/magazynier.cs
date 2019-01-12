using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazyn
{
    class magazynier
    {
        //stany magazynowe ksiazek
        int ksiazka_jeden = 2;
        int ksiazka_dwa = 10;
        int ksiazka_trzy = 10;  

        int paleta =  0;     //pojemnosc palaty max 5 paczek
        //stan
        List<int> lista_elementow = new List<int>();


        //zachowania
        public void dodaj_element(int nr_ksiazki)
        {
            if (nr_ksiazki == 1)
            {
                if (ksiazka_jeden > 0)
                {
                    lista_elementow.Add(nr_ksiazki);
                }
                else
                {
                    Console.WriteLine("Brak ksiązki 1 na stanie!");
                }
            }
            if (nr_ksiazki == 2)
            {
                if (ksiazka_dwa > 0)
                {
                    lista_elementow.Add(nr_ksiazki);
                }
                else
                {
                    Console.WriteLine("Brak ksiązki 2 na stanie!");
                }
            }
            if (nr_ksiazki == 3)
            { 
                if (ksiazka_trzy > 0)
                {
                    lista_elementow.Add(nr_ksiazki);
                }
                else
                {
                    Console.WriteLine("Brak ksiązki 3 na stanie!");
                }
            }
        }
        public void odejmi_ksiazke_zestanu()
        {
            string nowyOdejmi = string.Empty;

            foreach (int odejmi in lista_elementow)
            {
               
                    if (odejmi == 1)
                    {
                    if (ksiazka_jeden > 0)
                    {
                        ksiazka_jeden = ksiazka_jeden - 1;
                        Console.WriteLine("Stan magazynowy książki nr 1:    {0}", ksiazka_jeden);
                    }
                   
                    }
                if (odejmi == 2)
                {
                    if (ksiazka_dwa > 0)
                    {
                        ksiazka_dwa = ksiazka_dwa - 1;
                        Console.WriteLine("Stan magazynowy książki nr 2:    {0}", ksiazka_dwa);
                    }
                    
                }
                if (odejmi == 3)
                {
                    if (ksiazka_trzy > 0)
                    {
                        ksiazka_trzy = ksiazka_trzy - 1;
                        Console.WriteLine("Stan magazynowy książki nr 3:    {0}", ksiazka_trzy);
                    }
                    
                }


            }
            Console.WriteLine(ksiazka_jeden);

        }

        public void  pakowanie()
        {
            foreach (var nr_ksiazki in lista_elementow)
            {
                if (nr_ksiazki == 1)
                {
                Console.WriteLine("Pakuje " + nr_ksiazki);
                System.Threading.Thread.Sleep(3000);
                    if (paleta < 6)
                    {
                        paleta = paleta + 1;
                    }
                    else
                    {
                        Console.WriteLine("Śpię bo nie mogę oddać paczek na paletę");
                    }
                }
                if (nr_ksiazki == 2)
                {
                    Console.WriteLine("Pakuje " + nr_ksiazki);
                    System.Threading.Thread.Sleep(2000);
                    if (paleta < 6)
                    {
                        paleta = paleta + 1;
                    }
                    else
                    {
                        Console.WriteLine("Śpię bo nie mogę oddać paczek na paletę");
                    }

                }
                if (nr_ksiazki == 3)
                {
                    Console.WriteLine("Pakuje " + nr_ksiazki);
                    System.Threading.Thread.Sleep(4000);
                    if (paleta < 6)
                    {
                        paleta = paleta + 1;
                    }
                    else
                    {
                        Console.WriteLine("Śpię bo nie mogę oddać paczek na paletę");
                    }
                }
                

            }
        }
        public void pokaz_liste()
        {
            string nowyTekst = string.Empty;

            foreach (int tekst in lista_elementow)
            {
                nowyTekst += " " + tekst;
            }
            Console.Write("Aktualna lista książek do spakowania: ");
            Console.WriteLine(nowyTekst);
        }
        public void dlugosc_listy()
        {
            Console.Write("Długość listy zamówień: ");
            Console.WriteLine(lista_elementow.Count());
        }

        public void wyczysc_liste()
        {
            
                lista_elementow.Clear();
                
            
        }
        

    }
}
