using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _DashboardStatisticComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Experiences.Count(); //toplam yetenek sayısını getirir
            ViewBag.v2 = context.Testimonials.Count(); 
            ViewBag.v3 = context.Skills.Count();
            ViewBag.v4 = context.ToDoLists.Count(); 
            return View();
        }
    }
    
}
