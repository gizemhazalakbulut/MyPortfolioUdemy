using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience() /*burası sayfa yüklenince çalışacak*/
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience) /*burasıda sayfada bir butona tıklandığında çalışacak*/
        {
            context.Experiences.Add(experience); //veritabanına ekle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("ExperienceList"); //yeni bir sayfaya yönlendir
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id); //id'si gelen veriyi bul
            context.Experiences.Remove(value); //veritabanından sil
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("ExperienceList"); //yeni bir sayfaya yönlendir
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id); //id'si gelen veriyi bul
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience); //veritabanında güncelle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("ExperienceList"); //yeni bir sayfaya yönlendir
        }
    }
}
