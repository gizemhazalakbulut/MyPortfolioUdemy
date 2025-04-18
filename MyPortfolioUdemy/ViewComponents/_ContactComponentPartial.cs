﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactTitle = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactDescription = context.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactPhone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.contactPhone2 = context.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.contactEmail1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.contactEmail2 = context.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.contactAddress = context.Contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
