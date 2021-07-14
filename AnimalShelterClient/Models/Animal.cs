using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalShelterClient.Models
{
	public class Animal
	{
		public int AnimalId { get; set; }
		public string Name { get; set; }
		public string Species { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }

		public static List<Animal> GetAnimals()
		{
			Task<string> apiCallTask = ApiHelper.GetAll();
			string result = apiCallTask.Result;

			JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
			List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

			return animalList;
		}

		public static Animal GetDetails(int id)
		{
			Task<string> apiCallTask = ApiHelper.Get(id);
			string result = apiCallTask.Result;

			JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
			Animal animal = JsonConvert.DeserializeObject<Animal>(jsonResponse.ToString());

			return animal;
		}
	}
}