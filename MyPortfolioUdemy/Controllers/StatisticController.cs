using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count(); //toplam yetenek sayısını getirir
            ViewBag.v2 = context.Messages.Count(); //Messages tablosundaki toplam kayıt sayısını getirir
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count(); //okunmamış mesaj sayısını getirir
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count(); //okunmuş mesaj sayısını getirir
            ViewBag.v5 = context.Portfolios.Count(); //toplam portfolyo sayısını getirir
            ViewBag.v6 = context.Portfolios.Where(x => x.SubTitle=="Branding").Count(); // subtitle'ı Branding olan portfolyo sayısını getirir
            ViewBag.v7 = context.Portfolios.Where(x => x.SubTitle == "Web Design").Count(); // subtitle'ı Web Design olan portfolyo sayısını getirir
            ViewBag.v8 = context.Portfolios.Where(x => x.SubTitle == "Web Development").Count(); // subtitle'ı Web Development olan portfolyo sayısını getirir
            ViewBag.v9 = context.Experiences.Count(); //toplam deneyim sayısını getirir
            ViewBag.v10 = context.Experiences.Where(x => x.Title == "Backend Developer").Count(); //toplam deneyim sayısını getirir
            ViewBag.v11 = context.Experiences.Where(x => x.Title == "Frontend Developer").Count(); //toplam deneyim sayısını getirir
            ViewBag.v12 = context.Experiences.Where(x => x.Title == "Full Stack Developer").Count(); //toplam deneyim sayısını getirir
            ViewBag.v13 = context.Testimonials.Count(); //toplam referans sayısını getirir
            ViewBag.v14 = context.Testimonials.Where(x => x.Title == "Müdür").Count(); //toplam müdür referans sayısını getirir
            ViewBag.v15 = context.Testimonials.Where(x => x.Title == "Eğitmen").Count(); //toplam Eğitmen referans sayısını getirir
            ViewBag.v16 = context.Testimonials.Where(x => x.Title == "CIO").Count(); //toplam CIO referans sayısını getirir
            return View();
        }
    }
}
