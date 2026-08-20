using Microsoft.AspNetCore.Mvc;
using DooRoomDemo.Models;

namespace DooRoomDemo.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            House house = new House()
            {
                Id = Guid.NewGuid(),
                Rooms = new List<Room>
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
                }
            };
            return View(house);
        }
    }
}
