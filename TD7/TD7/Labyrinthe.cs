using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD7
{
    internal class Labyrinthe
    {
        private int[,] matrice;
        private int nbLignes;
        private int nbColonnes;

        private Position depart;
        private Position arrivee;


        public Labyrinthe(string[] schema1, int nbLignes, int nbColonnes)
        {

            this.nbLignes = nbLignes;
            this.nbColonnes = nbColonnes;
            int[,] temp = new int[nbLignes, nbColonnes];

            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    if (schema1[i][j] == '-')
                    {

                        temp[i, j] = 0;
                    }
                    if (schema1[i][j] == '*')
                    {
                        temp[i, j] = 1;
                    }
                    if (schema1[i][j] == 'd')
                    {
                        temp[i, j] = 2;
                    }
                    if (schema1[i][j] == 'a')
                    {
                        temp[i, j] = 3;
                    }

                }
            }
            this.matrice = temp;


        }

        public Position Arrivee
        {
            get { return arrivee; }
        }

        public Position Depart
        {
            get { return depart; }
        }

        public int[,] Matrice
        {
            get { return matrice; }
            set { matrice = value; }
        }
        public int NbLignes
        {
            get { return nbLignes; }
        }

        public int NbColonnes
        {
            get { return nbColonnes; }
        }
        public bool EstMur(Position pos)
        {
            bool rep = false;
            if (matrice[pos.Ligne, pos.Colonne] == '1')
            {
                rep = true;
            }
            return rep;
        }

        public bool EstOccupee(Position pos)
        {
            bool rep = false;
            if (matrice[pos.Ligne, pos.Colonne] == '4')
            {
                rep = true;
            }
            return rep;
        }

        public bool MarquerPassage(Position pos)
        {
            bool rep = false;
            if (EstMur(pos) == false && EstOccupee(pos) == false)
            {
                rep = true;
            }
            return rep;

        }

        public string toString()
        {
            string rep = "";
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (matrice[i, j] == 0)
                    {

                        rep += "-";
                    }
                    if (matrice[i, j] == 1)
                    {
                        rep += "*";
                    }
                    if (matrice[i, j] == 2)
                    {
                        rep += "d";
                    }
                    if (matrice[i, j] == 3)
                    {
                        rep += "a";
                    }
                    if (matrice[i, j] == 4)
                    {
                        rep += ".";
                    }

                }
                rep += "\n";
            }
            return rep;
        }


    }
}
