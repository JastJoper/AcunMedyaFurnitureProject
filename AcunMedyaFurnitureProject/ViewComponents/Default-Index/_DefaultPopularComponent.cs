using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
	public class _DefaultPopularComponent:ViewComponent
    {
		private readonly FurnitureContext _context;

        public _DefaultPopularComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{ 
            var values = _context.Abouts.ToList();
			return View(values); 
		}
	}
}
