using AcunMedyaFurnitureProject.DataAccess.Entities;
using AcunMedyaFurnitureProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class RegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Signup(RegisterViewModel model)
        {

            var user = new AppUser
            {
                Email = model.Email,
                UserName = model.UserName,
                NameSurname = model.NameSurname,

            };
                
            var result = await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.Code, item.Description);
            }

            return View(); 
        
        }


    }
}
