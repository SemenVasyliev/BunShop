using Microsoft.AspNetCore.Mvc;
using Shop2.Data.Interfaces;
using Shop2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Controllers
{
    public class BunsController : Controller
    {

        private readonly IAllBuns _allBuns;
        private readonly IBunsCategory _allCategories;

        public BunsController(IAllBuns iAllBuns, IBunsCategory iBunsCat)
        {
            _allBuns = iAllBuns;
            _allCategories = iBunsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с булками";
            BunsListViewModel obj = new BunsListViewModel();
            obj.allBuns = _allBuns.Buns;
            obj.currCategory = "Булки";
            return View(obj);
        }

    }
}
