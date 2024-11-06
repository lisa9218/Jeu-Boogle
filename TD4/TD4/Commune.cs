using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD4
{
    internal class Commune
    {
        private string nom;
        private int departement;
        private string pays;
        private string maire;
        private int nbHabitant;

        public Commune(string nom,int departement, string pays, string maire, int nbHabitant)
        {
            if (departement > 0)
            {
                this.departement = departement;
            }
            else
            {
                this.departement = -1;
            }
            this.nom = nom.ToUpper();
            this.pays = pays.ToUpper();
            this.maire = maire.ToLower();
            if (nbHabitant > 0)
            {
                this.nbHabitant = nbHabitant;
            }
            else
            {
                this.nbHabitant = -1;
            }
        }

        public int Nbhabitant
        {
            get { return this.nbHabitant; }
            set { if (value < 0)
                {
                    value = -1;
                }
                else
                {
                    this.nbHabitant = value;
                }
            }
        }

        public string Maire
        {
            get { return this.maire; }
            set
            {
                maire = value.ToLower();
            }
         }

        public string Nom
        {
            get { return this.nom; }
            set
            {
                nom = value.ToUpper();
            }
        }
       
        public string toString()
        {
            return "nom : "+this.nom+"\ndepartement : "+this.departement+"\npays : "+this.pays+"\nmaire : "+this.maire+"\nNombre d'habitant: "+this.nbHabitant;
        }

        public  bool equals(Commune c)
        {
            if(c.nbHabitant == this.nbHabitant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool equalStatic (Commune a, Commune b)
        {
            if (a.nbHabitant == b.nbHabitant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        



    }
}
