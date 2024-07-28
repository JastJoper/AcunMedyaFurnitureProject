using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.UILayout
{
	public class _UILayoutFooterComponent:ViewComponent
	{
		private readonly FurnitureContext _context;

		public _UILayoutFooterComponent(FurnitureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var values = _context.Subscribers.ToList();

			return View(values);
		}
	}
}
