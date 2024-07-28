using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[Area]/[Controller]/[Action]/{id?}")]

	public class TestimonialController : Controller
	{
		private readonly FurnitureContext _context;

		public TestimonialController(FurnitureContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.Testimonials.ToList();
			return View(values);
		}
		public ActionResult DeleteTestimonial(int id)
		{
			var value = _context.Testimonials.Find(id);
			_context.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult CreateTestimonial()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateTestimonial(Testimonial testimonial)
		{
			_context.Add(testimonial);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]

		public IActionResult UpdateTestimonial(int id)
		{
			var value = _context.Testimonials.Find(id);
			return View(value);

		}

		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_context.Update(testimonial);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
