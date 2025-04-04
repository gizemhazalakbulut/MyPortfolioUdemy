using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        { 
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList p)
        {
            p.Status = false;  //Varsayılan olarak false atıyoruz
            context.ToDoLists.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList p)
        {
           context.ToDoLists.Update(p); //Update metodu ile güncellenir
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true; //Status'u true yapıyoruz
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false; //Status'u true yapıyoruz
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
