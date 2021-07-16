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

		[Route("v{version}/animals/{id}/edit")]
		public IActionResult Edit(int id)
		{
			Animal animal = Animal.GetDetails(id);
			return View(animal);
		}

		[HttpPost]
		[Route("v{version}/animals/{id}/edit")]
		public async Task<IActionResult> Edit(int id, Animal animal)
		{
			animal.AnimalId = id;
			await Animal.Put(animal);
			return RedirectToAction("Details", new { id = id, version = ApiHelper.ApiVersion });
		}

		[Route("v{version}/animals/{id}/delete")]
		public async Task<IActionResult> Delete(int id)
		{
			await Animal.Delete(id);
			return RedirectToAction("Index", new { version = ApiHelper.ApiVersion });
		}
	}
}