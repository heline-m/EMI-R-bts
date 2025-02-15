﻿using EMI_RA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_RA
{
    public class AssoProduitsFournisseursServices : IAssoProduitsFournisseursServices
    {
        private AssoProduitsFournisseurs_Depot_DAL depot = new AssoProduitsFournisseurs_Depot_DAL();

        public List<AssoProduitsFournisseurs> GetAll()
        {
            var assoProduits = depot.GetAll()
                .Select(a => new AssoProduitsFournisseurs(a.IdFournisseurs,
                                        a.IdProduits
                                        ))
                .ToList();

            return assoProduits;
        }
        public List<AssoProduitsFournisseurs> GetByIdProduit(int idProduits)
        {

            var result = new List<AssoProduitsFournisseurs>();

            foreach (var a in depot.GetByIdProduit(idProduits))
            {
                AssoProduitsFournisseurs asso = new AssoProduitsFournisseurs(a.IdFournisseurs,
                                        a.IdProduits
                              );
                result.Add(asso);
            }
            return result;
        }
        public AssoProduitsFournisseurs GetByIdFournisseurs(int idFournisseurs)
        {
            var a = depot.GetByIdFournisseurs(idFournisseurs);

            return new AssoProduitsFournisseurs(a.IdFournisseurs,
                                        a.IdProduits
                              );
        }
        public AssoProduitsFournisseurs Insert(AssoProduitsFournisseurs a)
        {
            var assoProduits = new AssoProduitsFournisseurs_DAL(a.IdFournisseurs,
                                        a.IdProduits);
            depot.Insert(assoProduits);


            return a;
        }

        public void Delete(int idProduits, int idFournisseurs)
        {
            depot.Delete(idProduits, idFournisseurs);

        }
    }
}
