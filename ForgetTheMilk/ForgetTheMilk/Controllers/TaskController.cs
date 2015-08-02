using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForgetTheMilk.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult Index()
        {
            return View(Tasks);
        }

        public static readonly List<Task> Tasks = new List<Task>();

        [HttpPost]
        public ActionResult Add(string task)
        {
            Tasks.Add(new Task() {Description = task});
            return RedirectToAction("Index");
        }
    }

    public class Task
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}