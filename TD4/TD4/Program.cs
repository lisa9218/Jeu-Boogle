// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using TD4;

namespace MyApp 
{
    internal class Program
    {
        //Exercice 1
        
        static void Main(string[] args)
        {
           

            Commune Paris=new Commune("Paris", 75, "France", "Hidalgo", 2200000);
            Commune Marly= new Commune("Marly", 78, "France", "Lamy", 10000); 
            Commune Versailles=new Commune("Versailles", 78, "France", "Toto", 100000);
            Commune Rouen=new Commune("Rouen", 76, "France", "Robert", 111000);
            Commune LeHavre = new Commune("Le havre", 76, "France", "Edouard Philippe", 172366);

           Paris.Nbhabitant= 2220000; 
            string s=Paris.toString();
            bool b=Paris.equals(Rouen);
            Console.WriteLine(s);

            Commune[] tab= { Marly, Versailles, Paris };
            Commune[] tab1 = { Rouen, LeHavre };

            Region IleDeFrance=new Region("IleDeFrance", tab, "", "Paris");
            Console.WriteLine(IleDeFrance.Appartenance("Marly"));
            IleDeFrance.CommuneOrdre();
            s=IleDeFrance.toString();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
