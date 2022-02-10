using System;
using System.Collections.Generic;
using System.Text;

namespace gestion_parc_véhicules
{
    public abstract class Vehicule
    {
        // soit voiture, soit utilitaire
        protected string immatriculation;
        protected string marque;
        protected string couleur;

        public string Immatriculation { get { return immatriculation; } }

        public Vehicule(string _imm, string _marque, string _coul)
        {
            immatriculation = _imm;
            marque = _marque;
            couleur = _coul;
                
        }
        public override string ToString()
        {
            return "Véhicule " + Immatriculation + " ( " + marque + " " + couleur + " ) ";
        }

    }

   
}
