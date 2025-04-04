﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count(); // yapılmamış olan bildirim sayısı
            var values = context.ToDoLists.Where(x =>x.Status==false).ToList(); // yapılmamış olanları bildirimde getiricez
            return View(values);
        }
    }
  
}
