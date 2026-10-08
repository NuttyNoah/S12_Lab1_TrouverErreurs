using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission.Data;
using Mission.ViewModels;
using Mission.Models;

namespace Mission.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly MissionDbContext _context;

        public ProduitsController(MissionDbContext context)
        {
            _context = context;
        }

        // GET: Produits
        public async Task<IActionResult> Index()
        {
            // COMPLÉTER ICI
            //var categories = _context.Categories;
            //List<Produit> l= new List<Produit>();

            //foreach (var c in categories) {

            //    foreach(var p in c.Produits)
            //    {
            //        bool pareil = false;
            //        foreach(Produit  produit in l)
            //        {
            //            if (p == produit)
            //            {
            //                pareil = true;
            //            }
            //        }
            //        if (pareil == false)
            //        {
            //            l.Add(p);
            //        }
            //    }
            //}


            //return View(l);
            return View(_context.Produits);
        }

    }
}
