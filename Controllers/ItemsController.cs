//this contoller to be responsible for handling routes that pertain to Items

//Note convention to pluralize ItemsController

//using statements
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")] //returns a view that shows todo list
        public ActionResult Index()
        {
            Item newItem = new Item(Request.Query["new-item"]);
            return View(newItem);
        }

        [HttpGet("/items/new")] //returns view to show form for creating new item
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
