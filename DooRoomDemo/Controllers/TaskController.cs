using DooRoomDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DooRoomDemo.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            List<TaskItem> taskItems = new List<TaskItem>
            {
                new TaskItem {
                TaskName = "Study",
                TaskDescription = "Study for the exam",
                Keywords = new List<string> { "study", "exam" },
                TaskStatus = false
            },
                new TaskItem {
                TaskName = "Exercise",
                TaskDescription = "Go to the gym",
                Keywords = new List<string> { "exercise", "gym" },
                TaskStatus = false
            },
                new TaskItem {
                TaskName = "Grocery Shopping",
                TaskDescription = "Buy groceries for the week",
                Keywords = new List<string> { "grocery", "shopping" },
                TaskStatus = false
                }
            };
            return View(taskItems);
        }
    }
}
