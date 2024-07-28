using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
	public class ProductsController : Controller
	{
		private readonly FurnitureContext _context;

		public ProductsController(FurnitureContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.Products.ToList();

			return View(values);
		}
	}
}
