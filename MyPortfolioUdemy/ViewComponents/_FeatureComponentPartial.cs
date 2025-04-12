using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.featureTitle = portfolioContext.Features.Select(x => x.Title).FirstOrDefault();
            ViewBag.featureDescription = portfolioContext.Features.Select(x => x.Description).FirstOrDefault();
            return View();
        }
    }
}
