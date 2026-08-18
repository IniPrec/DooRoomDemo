using DooRoomDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DooRoomDemo.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            List<Room> room = new List<Room>
            {
                new Room
                {
                    Name = "Study room",
                    Type = "Study",
                    IsUnlocked = false,
                },
                new Room
                {
                    Name = "Kitchen",
                    Type = "wash, dishes",
                    IsUnlocked = false
                },
                new Room
                {
                    Name = "Gym",
                    Type = "exercise",
                    IsUnlocked = false
                }
            };
            return View();
        }
    }
}
