using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD4
{
    internal class Region
    {
        private string nom;
        private Commune[] communes;
        private string prefet;
        private string chefLieu;


        public Region(string nom, Commune[] communes, string prefet, string chefLieu)
        {
            this.nom = nom;
            this.communes = communes;
            this.prefet = prefet;
            this.chefLieu = chefLieu;
            
        }
       

        public string toString()
        {
            string c = "nom: " + this.nom +"\nprefet: " + this.prefet + "\nchef Lieu: " + this.chefLieu+"\nCommune: ";
            for(int i=0; i < this.communes.Length; i++)
            {
                c += this.communes[i].toString();
            }
            return c;
            
        }

        public int population(Region a)
        {
            int rep = 0;
            for(int i=0; i<a.communes.Length; i++)
            {
                rep += a.communes[i].Nbhabitant;
                
            }
            return rep;
        }

        public bool Appartenance (string c)
        {
            bool rep = false;
            for(int i=0; i<this.communes.Length; i++)
            {
                if (this.communes[i].Nom == c.ToUpper())
                {
                    rep = true;
                }
            }
            return rep;
        }

        public void CommuneOrdre()
        {
            bool triTermine = false;
            while (triTermine == false)
            {
                triTermine = true;
                for(int i=0; i< this.communes.Length-1; i++)
                {
                    if (String.Compare(this.communes[i].Nom, this.communes[i+1].Nom) > 0)
                    {
                        Commune temporaire=this.communes[i];
                        this.communes[i]=this.communes[i+1];
                        this.communes[i + 1] = temporaire;
                        triTermine = false;

                    }
                }
            }

            
        }




    }
}
