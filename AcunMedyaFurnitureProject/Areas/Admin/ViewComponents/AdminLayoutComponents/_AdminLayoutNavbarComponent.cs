using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutNavbarComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminLayoutNavbarComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity?.Name == null)
            {
                // Kullanıcı kimlik doğrulaması yapılmamışsa yapılacak işlem
                ViewBag.name = "Misafir"; // Ya da göstermek istediğiniz başka bir değer
                return View();
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                // Kullanıcı bulunamazsa yapılacak işlem
                ViewBag.name = "Bilinmeyen Kullanıcı";
            }
            else
            {
                ViewBag.name = user.UserName;
            }

            return View();
        }
    }
}
