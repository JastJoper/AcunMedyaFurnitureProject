using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly FurnitureContext _context;

		public ContactUsController(FurnitureContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{

			return View();
		}
	}
}
