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
                    Type = new List<string> { "Study" },
                    IsUnlocked = false,
                },
                new Room
                {
                    Name = "Kitchen",
                    Type = new List<string> { "wash, dishes" },
                    IsUnlocked = false
                },
                new Room
                {
                    Name = "Gym",
                    Type = new List < string > { "exercise" },
                    IsUnlocked = false
                }
            };
            return View(room);
        }
    }
}
