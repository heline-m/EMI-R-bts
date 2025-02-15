﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMI_RA.API.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ProduitsController : Controller
    {
        private IProduitsService service;

        public ProduitsController(IProduitsService srv)
        {
            service = srv;
        }

        [HttpGet]
        public IEnumerable<Produits> Get()
        {
            return service.GetAll();
        }

        [HttpGet("{id}")]
        public Produits GetProduitsById(int id)
        {
            return service.GetProduitsByID(id);
        }
    }
}
