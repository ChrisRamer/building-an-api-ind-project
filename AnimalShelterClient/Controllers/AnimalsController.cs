using AnimalShelterClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalShelterClient.Controllers
{
	public class AnimalsController : Controller
	{
		// GET v{version}/animals
		[Route("v{version}/animals")]
		public IActionResult Index()
		{
			List<Animal> allAnimals = Animal.GetAnimals();
			return View(allAnimals);
		}

		// GET v{version}/animals/{id}
		[Route("v{version}/animals/{id}")]
		public IActionResult Details(int id)
		{
			Animal animal = Animal.GetDetails(id);
			return View(animal);
		}

		[Route("v{version}/animals/create")]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[Route("v{version}/animals/create")]
		public async Task<IActionResult> Create(Animal animal)
		{
			await Animal.Post(animal);
			return RedirectToAction("Index");
		}
	}
}