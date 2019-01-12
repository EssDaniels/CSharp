using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace magazyn
{
    



    class Program

    {

        static void Main(string[] args)
        {
            

            magazynier magazynier = new magazynier();
            magazynier.dodaj_element(1);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(1);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(1);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(1);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(2);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(1);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(3);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(1);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(3);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(3);
            magazynier.odejmi_ksiazke_zestanu();
            magazynier.dodaj_element(3);
            magazynier.odejmi_ksiazke_zestanu();


            magazynier.dlugosc_listy();
            magazynier.pokaz_liste();
            magazynier.pakowanie();
            
            
          
            magazynier.wyczysc_liste();
            magazynier.dlugosc_listy();
            Console.WriteLine();
            System.Console.ReadLine();
        }

    }
}
