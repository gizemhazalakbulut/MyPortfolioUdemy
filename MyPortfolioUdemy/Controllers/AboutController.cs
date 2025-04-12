using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult AboutList()
        {
            ViewBag.v1 = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.v2 = context.Abouts.Select(x => x.AboutId).FirstOrDefault();
            return View();
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About p)
        {
            context.Abouts.Update(p);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
