using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class AboutSiteController : Controller
    {
        private readonly FurnitureContext _context;

		public AboutSiteController(FurnitureContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View();
        }
    }
}
