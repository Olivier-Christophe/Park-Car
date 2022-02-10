using System;
using System.Collections.Generic;
using System.Text;

namespace gestion_parc_véhicules
{
    public class Utilitaire : Vehicule
    {
        protected int volume;
        public Utilitaire(string _imm, string _marque, string _coul, int _volume) : base (_imm, _marque, _coul)
        {
            volume = _volume;

        }
        public override string ToString()
        {
            return base.ToString() + ": Utilitaire de " + volume + " m3  ";
        }
    }
}
