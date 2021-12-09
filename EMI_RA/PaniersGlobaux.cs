﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_RA
{
    public class PaniersGlobaux
    {
        public int IDPaniersGlobaux { get; set; }
        public int NumeroSemaine { get; set; }
        public int Annee { get; set; }

        public PaniersGlobaux(int numeroSemaine, int annee)
                    => (NumeroSemaine, Annee) = (numeroSemaine, annee);
        public PaniersGlobaux(int idPaniersGlobaux, int numeroSemaine, int annee)
                    => (IDPaniersGlobaux, NumeroSemaine, Annee) = (idPaniersGlobaux, numeroSemaine, annee);
    }
}
