﻿using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{

	[Area("Admin")]
	[Route("[Area]/[Controller]/[Action]/{id?}")]
	[Authorize]
	public class ProductController : Controller
	{
		private readonly FurnitureContext _context;

		public ProductController(FurnitureContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.Products.ToList();

			return View(values);
		}

		public IActionResult DeleteProduct(int id)
		{
			var value = _context.Products.Find(id);
			_context.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult CreateProduct()
		{
			return View();
		}

		[HttpPost]

		public IActionResult CreateProduct(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		
		}

		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			var value = _context.Products.Find(id);
			return View(value);

		}

		[HttpPost]
		public IActionResult UpdateProduct(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}	
}
