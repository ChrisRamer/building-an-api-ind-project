using AnimalShelterClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AnimalShelterClient.Controllers
{
	public class AnimalsController : Controller
	{
		// GET {version}/animals
		[Route("v{version}/animals")]
		public IActionResult Index()
		{
			List<Animal> allAnimals = Animal.GetAnimals();
			return View(allAnimals);
		}
	}
}