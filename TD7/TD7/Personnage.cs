using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD7
{
    internal class Personnage
    {
        private Labyrinthe laby;
        private Position pos;

        public Personnage(Labyrinthe laby)
        {
            this.laby = laby;
            this.pos = laby.Depart;
        }
        public bool EstArrivee()
        {
            if (laby == null || pos == null)
            {
                return false;
            }
            return laby.Arrivee.Estegal(this.pos);

        }

        public Position Pos
        {
            get { return pos; }
        }

        public void DeplacementSuivant()
        {
            if (pos == null)
            {
                Console.WriteLine("erruer");
            }
            int ligne;
            int colonne;

            Console.WriteLine("Saisi la position ligne ");
            ligne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisi la position colonne ");
            colonne = Convert.ToInt32(Console.ReadLine());
            if (ligne < 0 || ligne >= laby.NbLignes || colonne < 0 || colonne >= laby.NbColonnes)
            {
                Console.WriteLine("Position invalide !");
                return;
            }
            pos.Ligne = ligne;
            pos.Colonne = colonne;
        }

    }
}
