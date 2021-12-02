﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_RA.DAL
{
    public abstract class Offres_Depot_DAL : Depot_DAL<Offres_DAL>
    {
        public Offres_Depot_DAL()
            : base()
        {

        }

        public override List<Offres_DAL> GetAll()
        {
            CreerConnexionEtCommande();

            commande.CommandText = "select idFournisseurs, idLignesPaniers, prix from offres";
            //pour lire les lignes une par une
            var reader = commande.ExecuteReader();

            var listeDOffres = new List<Offres_DAL>();

            while (reader.Read())
            {
                //dans reader.GetInt32 on met la colonne que l'on souhaite récupérer ici 0 = ID, 1 = Societe...
                var offre = new Offres_DAL(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));

                listeDOffres.Add(offre);
            }

            DetruireConnexionEtCommande();

            return listeDOffres;
        }


        public override Offres_DAL Insert(Offres_DAL offre)
        {
            CreerConnexionEtCommande();

            commande.CommandText = "insert into offres (idFournisseurs, idLignesPaniers, prix)"
                                    + " values (@idFournisseurs, @idLignesPaniers, @prix);";
            commande.Parameters.Add(new SqlParameter("@idFournisseurs", offre.IdFournisseurs));
            commande.Parameters.Add(new SqlParameter("@idLignesPaniers", offre.IdLignesPaniers));
            commande.Parameters.Add(new SqlParameter("@prix", offre.Prix));

            DetruireConnexionEtCommande();

            return offre;
        }

       
    }
}
