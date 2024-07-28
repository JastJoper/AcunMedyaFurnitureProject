using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
    public class _DefaultProductComponent : ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultProductComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Products.OrderBy(x => x.ProductId).Take(3).ToList();
            return View(values);
        }
    }
}
