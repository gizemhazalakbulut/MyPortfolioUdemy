using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill() /*burası sayfa yüklenince çalışacak*/
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill) /*burasıda sayfada bir butona tıklandığında çalışacak*/
        {
            context.Skills.Add(skill); //veritabanına ekle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("SkillList"); //yeni bir sayfaya yönlendir
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id); //id'si gelen veriyi bul
            context.Skills.Remove(value); //veritabanından sil
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("SkillList"); //yeni bir sayfaya yönlendir
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id); //id'si gelen veriyi bul
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill); //veritabanında güncelle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("SkillList"); //yeni bir sayfaya yönlendir
        }
    }
}

