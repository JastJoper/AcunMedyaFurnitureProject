using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
	public class _DefaultHelpComponent:ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultHelpComponent(FurnitureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{

			return View(); 
		}
	}
}
