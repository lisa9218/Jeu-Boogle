// See https://aka.ms/new-console-template for more information
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program1
    {
        public class Article
        {
            long reference;
            string intitule;
            float prixHT;
            int quantiteEnStock;

            private static int NbClients = 0;
            private static int NbClientBloque = 0;

            public Article(long reference, string intitule, float prixHT, int quantiteEnStock)
            {
                this.reference = reference;
                this.intitule = intitule;
                this.prixHT = prixHT;
                this.quantiteEnStock = quantiteEnStock;
            }

            public long Reference
            {
                get { return reference; }

            }

            public string Intitule
            {
                get { return intitule; }
            }

            public float PrixHT
            {
                get { return prixHT; }
            }

            public int QuantiteEnStock
            {
                get { return quantiteEnStock; }
            }

            public void approvisionner(int nombreUnites)
            {
                this.quantiteEnStock += nombreUnites;
            }

            public bool vendre(int nombreUnites)
            {
                bool rep = false;
                if (nombreUnites < this.quantiteEnStock)
                {
                    rep = false;
                }
                else
                {
                    rep = true;
                    this.quantiteEnStock -= nombreUnites;
                }
                return rep;
            }

            public float prixTTC()
            {
                float prixTTC = 0;
                prixTTC = Convert.ToSingle(this.prixHT * 1.20);
                return prixTTC;
            }

            public string toString()
            {
                string rep = "";
                float prix = prixTTC();
                rep = "La refernce de l'article est " + this.reference + ". L'intitulé de l'article est " + this.intitule + ". le prix de l'article est "+prix; 
                return rep;
            }

            public bool equals(Article unArticle)
            {
                bool rep = false;
                if (unArticle.reference == this.reference)
                {
                    rep = true;
                }
                else
                {
                    rep = false;
                }    
                return rep;
            }
        }
        
        public class CompteBancaire
        {
            string NomClient;
            float MontantDuCompte;
            bool flag;
            private int TentativesEchouees;

            private static int NombreTotalClients = 0;
            private static int NombreClientsBloques = 0;

            public CompteBancaire(string Nomclient,  float MontantDuCompte, bool flag)
            {
                this.NomClient=Nomclient;
                this.MontantDuCompte = MontantDuCompte;
                this.flag = flag;
                TentativesEchouees = 0;

                NombreTotalClients++;
                if (flag)
                {
                    NombreClientsBloques++;
                }
            }

            public CompteBancaire(string NomClient, float MontantDuCompte)
            {
                this.NomClient = NomClient;
                this.MontantDuCompte = MontantDuCompte;
                this.flag = false;
            }

            public bool CompteBloque()
            {
                bool rep = false;
                if (Debit() >= 2)
                {
                    this.flag = false;
                }
                if (credit() == true)
                {
                    this.flag = true;
                }
                if (this.flag == false)
                {
                    rep = false;
                }
                else
                {
                    rep = true;
                }
                NombreClientsBloques--;
                
               
                return rep;
            }

            public int Debit()
            {
                int nb = 0;
                Console.WriteLine("Quel montant voulez vous debiter?");
                float montant = float.Parse(Console.ReadLine());
                if (montant > this.MontantDuCompte)
                {
                    Console.WriteLine("debit refusé");
                    nb++;
                }
                else
                {
                    this.MontantDuCompte= this.MontantDuCompte-montant;
                    Console.WriteLine("vous avez été débité");
                    nb--;
                }
                if (nb < 0)
                {
                    nb = 0;
                }
                return nb;
            }

            public bool credit()
            {
                Console.WriteLine("Quel montant voulez vous crediter?");
                double montant=double.Parse(Console.ReadLine());
                bool crediter = true;
                double rep=this.MontantDuCompte + montant;
                NombreClientsBloques++;
                return crediter;
            }           
        }


        static void Main(string[] args)
        {
            Article article1 = new Article(1234, "jeu", 100, 10);
            Console.WriteLine(article1.prixTTC());

            Article article = new Article(1234, "Jeu vidéo", 100, 10);
            Console.WriteLine(article1.ToString());

            article1.approvisionner(5);
            Console.WriteLine("Après approvisionnement: " + article1.QuantiteEnStock);

            if (article1.vendre(8))
            {
                Console.WriteLine("Vente réussie.");
            }
            else
            {
                Console.WriteLine("Stock insuffisant pour la vente.");
            }

            Console.WriteLine("Quantité en stock après vente: " + article1.QuantiteEnStock);
        }
    }
    }
}