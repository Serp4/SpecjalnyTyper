using SpecjalnyTyper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SpecjalnyTyper.Controllers
{

    public class MatchController : Controller
    {
        private SpecjalnyTyperEntities db = new SpecjalnyTyperEntities();

        // GET: Match
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Vote(int id)
        {
            SetViewModel setViewModel = new SetViewModel();
            setViewModel.listGame = db.Game.Where(c => c.Set_Id == id).ToList();

            return View(setViewModel);
        }
        [HttpPost]
        public ActionResult Votes(SetViewModel games)
        {
            foreach (var game  in games.listGame)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public ActionResult ShowAdminMatch(int? id)
        {
            ViewBag.Team = new SelectList(db.Teams, "Team", "Team");
            return View(db.Game.Where(c => c.Set_Id == id).ToList());
        }
        [HttpPost]
        public ActionResult saveMatch(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Game.Add(game);
                db.SaveChanges();
                return RedirectToAction("ShowAdminMatch", new { id = game.Set_Id });
            }
            return View(game);
        }
        public ActionResult DeleteMatch(int? id, int? setId)
        {
            Game game = db.Game.Find(id);
            db.Game.Remove(game);
            db.SaveChanges();
            return RedirectToAction("ShowAdminMatch", new { id = setId });
        }
    }
}