﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain.Abstract;

namespace Store.Web.Controllers
{
    public class NavController : Controller
    {
        IProductRepository repository;

        public NavController (IProductRepository repo)
        {
            repository = repo;
        }

       public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Products
                .Select(product => product.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}