using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponents
{
	public class _AdminSidebarComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View(); 

		}
	}
}
