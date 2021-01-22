using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HuntTracker.Controllers;
using HuntTracker.Models;

namespace HuntTracker.Controllers
{
    public class HuntController : Controller
    {
        private readonly IHuntRepo repo;
        public HuntController(IHuntRepo repo)
        {
            this.repo=repo;
        }
        public IActionResult Index()
        {
            var hunts = repo.GetAllHunts();
            return View(hunts);
        }

        public IActionResult ViewHunt(int id)
        {
            var hunts = repo.GetHunt(id);

            return View(hunts);
        }

        public IActionResult InsertHunt()
        {
            var hunt = repo.AssignCategory();

            return View(hunt);
        }

        public IActionResult InserHuntToDatabase(Hunt huntToInsert)
        {
            repo.InsertHunt(huntToInsert);

            return RedirectToAction("Hunt");
        }
    }
}
