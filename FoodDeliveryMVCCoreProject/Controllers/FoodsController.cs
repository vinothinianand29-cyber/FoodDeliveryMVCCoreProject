using FoodDeliveryMVCCoreProject.Models;
using FoodDeliveryMVCCoreProject.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryMVCCoreProject.Controllers
{
    public class FoodsController : Controller
    {
        private readonly FoodDbContext _ctx;

        public FoodsController(FoodDbContext ctx)
        { 
            _ctx = ctx;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FoodDetails store)
        {
            if (ModelState.IsValid) 
            {
                _ctx.FoodData.Add(store); 
                _ctx.SaveChanges();
                ViewData["Msg"] = "Data stored Successfully";
                return RedirectToAction("Read");
            
            }
            return View(store);
        }


        public IActionResult Read()
        {
          var data =  _ctx.FoodData.ToList();
            return View(data);
        }

        public IActionResult Edit(Guid FoodId) 
        {
          var data = _ctx.FoodData.Find(FoodId);
         
          return View(data);
        
        }

        [HttpPost]
        public IActionResult Edit(FoodDetails save)
        {
            _ctx.FoodData.Update(save);
            _ctx.SaveChanges();
            return RedirectToAction("Read");

        }

        public IActionResult Delete(Guid FoodId) 
        {
         var data= _ctx.FoodData.Find(FoodId);
            if (data != null)
            { 
              _ctx.FoodData.Remove(data);
                _ctx.SaveChanges();
                return RedirectToAction("Read");
            
            }
            return View(); 
        }





    }
}
