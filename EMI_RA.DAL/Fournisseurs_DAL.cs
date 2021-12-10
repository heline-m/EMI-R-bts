﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EMI_RA.DAL
{
    public class Fournisseurs_DAL
    {
        public int IdFournisseurs { get; set; }

        public List<Fournisseurs_DAL> Fournisseurs { get; set; }
        public String Societe { get; set; }
        public String CiviliteContact { get; set; }
        public String NomContact { get; set; }
        public String PrenomContact { get; set; }
        public String Email { get; set; }
        public String Adresse { get; set; }

        public Fournisseurs_DAL(int iDFournisseurs, String societe, String civiliteContact, String nomContact, String prenomContact, String email, String adresse)
                    => (IdFournisseurs, Societe, CiviliteContact, NomContact, PrenomContact, Email, Adresse) = (iDFournisseurs, societe, civiliteContact, nomContact, prenomContact, email, adresse);


        // TODO : remplacer le string fourisseur par le Fournisseur une fois cet objet créé
        
    }
}
