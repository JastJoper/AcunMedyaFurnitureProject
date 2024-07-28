using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
	public class _DefaultChooseComponent:ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultChooseComponent(FurnitureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var values = _context.Services.ToList();

			return View(values); 
		}
	}
}
