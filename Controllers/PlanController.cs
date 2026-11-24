using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCAssig02.Contexts;

namespace MVCAssig02.Controllers
{
    public class PlanController :Controller
    {
       // BaseURL/Plans/Test
        //public IActionResult Test()
        //{
        //    return View();       //  Razor Page Test
        //}

        //List All Plans
        public async Task<IActionResult> Index()
        {
            using GymDbContext context = new GymDbContext();
            var Plans = await context.Plans.ToListAsync();
            return View(Plans);   //Passing Plans To The Index Views
            
        }



    }
}
