using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineers = db.Mountaineers.ToList();
                return this.View(mountaineers);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            if (mountaineer == null)
            {
                return RedirectToAction("Index");
            }

            using (var db = new RescueRegisterDbContext())
            {
                var currentMountaineer = new Mountaineer()
                {
                    Id = mountaineer.Id,
                    Name = mountaineer.Name,
                    Age = mountaineer.Age,
                    Gender = mountaineer.Gender,
                    LastSeenDate = mountaineer.LastSeenDate
                };
                db.Mountaineers.Add(currentMountaineer);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var editMountaineer = db.Mountaineers.Find(id);
                return this.View(editMountaineer);
            }   
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineers = db.Mountaineers.Update(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var foundId = db.Mountaineers.Find(id);
                return this.View(foundId);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountainners = db.Mountaineers.Remove(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}