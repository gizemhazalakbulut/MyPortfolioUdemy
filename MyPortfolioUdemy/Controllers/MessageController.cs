using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeIsReadTrue(int id)
        {
            var value = context.Messages.Find(id); //id'si gelen veriyi bul
            value.IsRead = true; //okundu olarak işaretle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("Inbox"); //yeni bir sayfaya yönlendir
        }

        public IActionResult ChangeIsReadFalse(int id)
        {
            var value = context.Messages.Find(id); //id'si gelen veriyi bul
            value.IsRead = false; //okunmadı olarak işaretle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("Inbox"); //yeni bir sayfaya yönlendir
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id); //id'si gelen veriyi bul
            context.Messages.Remove(value); //veritabanından sil
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("Inbox"); //yeni bir sayfaya yönlendir
        }

        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.Find(id); //id'si gelen veriyi bul
            return View(value);
        }
    }
}
