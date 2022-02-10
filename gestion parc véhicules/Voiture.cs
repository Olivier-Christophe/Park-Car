using System;
using System.Collections.Generic;
using System.Text;

namespace gestion_parc_véhicules
{
   public class Voiture : Vehicule
    {
        protected int nbPortes;
        public Voiture(string _imm, string _marque, string _coul, int _nbPortes) : base(_imm,_marque, _coul)
        {
            nbPortes = _nbPortes;
            //objet construit et initialisé
        }
        public override string ToString()
        {
            return base.ToString () + ": Voiture avec " + nbPortes + " portes ";
        }
    }
}
