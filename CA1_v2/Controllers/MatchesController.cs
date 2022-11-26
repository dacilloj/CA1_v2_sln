using CA1_v2.Models;
using CA1_v2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CA1_v2.Controllers
{
    public class MatchesController : Controller
    {
        IMatchRepo _repo;

        public MatchesController(IMatchRepo repo)
        {
            _repo = repo;
        }


        // GET: MatchesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MatchesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MatchesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatchesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Match m)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repo.CreateFixture(m);
                    return RedirectToAction(nameof(Index));

                }
                return View();
                
            }
            catch
            {
                return View();
            }
        }

        // GET: MatchesController/Edit/5
        public ActionResult Edit(int id)
        {
            var match = _repo.GetFixture(id);
            return View(match);
        }

        // POST: MatchesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MatchesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MatchesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
