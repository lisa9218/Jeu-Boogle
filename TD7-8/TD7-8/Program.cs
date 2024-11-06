// See https://aka.ms/new-console-template for more information
using System;
using TD7_8;

namespace TD7_8 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] schema1 = { "*******", "*d----*", "**---a*", "*******" };
            Labyrinthe laby = new Labyrinthe(schema1, 4, 7);
            Personnage personnage = new Personnage(laby);
            while (!personnage.EstArrivee())
            {
                
                Console.Clear();
                Console.WriteLine(laby.toString());

               
                personnage.DeplacementSuivant();

               
                if (laby.MarquerPassage(personnage.Pos))
                {
                   
                    laby.Matrice[personnage.Pos.Ligne, personnage.Pos.Colonne] = 4; 
                }
                else
                {
                    Console.WriteLine("Mouvement invalide ! Réessayez.");
                }
            }
            Console.WriteLine("Félicitations ! Vous êtes arrivé à destination.");
        }
    }
}
