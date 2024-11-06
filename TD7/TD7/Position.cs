using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD7
{
    internal class Position
    {
        private int ligne;
        private int colonne;

        public Position(int ligne, int colonne)
        {
            if (this.ligne < 0)
            {
                this.ligne = -this.ligne;
            }
            this.ligne = ligne;
            if (this.colonne < 0)
            {
                this.colonne = -this.colonne;
            }
            this.colonne = colonne;
        }

        public int Ligne
        {
            get { return this.ligne; }
            set
            {
                if (this.ligne > 0) { this.ligne = value; }
                else { this.ligne = --value; }
            }
        }

        public int Colonne
        {
            get { return this.colonne; }
            set
            {
                if (this.colonne > 0) { this.colonne = value; }
                else { this.colonne = --value; }
            }
        }

        public string toString()
        {
            return "La ligne est " + this.ligne + ". La colonne est " + this.colonne + ".";
        }

        public bool Estegal(Position pos)
        {
            bool rep = false;
            if (pos.ligne == this.ligne && pos.colonne == this.colonne)
            {
                rep = true;
            }
            return rep;
        }
    }
}
