using RestSharp;
using System.Threading.Tasks;

namespace AnimalShelterClient.Models
{
	public class ApiHelper
	{
		public static double ApiVersion { get; set; }

		public static bool HasReadPermission()
		{
			return ApiVersion > 1;
		}

		public static bool HasCreatePermission()
		{
			return ApiVersion > 2;
		}

		public static bool HasUpdatePermission()
		{
			return ApiVersion > 3;
		}

		public static bool HasDeletePermission()
		{
			return ApiVersion > 4;
		}

		public static async Task<string> GetAll()
		{
			RestClient client = new RestClient($"http://localhost:5004/v{ApiVersion}");
			RestRequest request = new RestRequest("/animals", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task<string> Get(int id)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{ApiVersion}");
			RestRequest request = new RestRequest($"/animals/{id}", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task Post(string animal)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{ApiVersion}");
			RestRequest request = new RestRequest("/animals", Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody(animal);
			IRestResponse response = await client.ExecuteTaskAsync(request);
		}

		public static async Task Put(int id, string animal)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{ApiVersion}");
			RestRequest request = new RestRequest($"/animals/{id}", Method.PUT);
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody(animal);
			IRestResponse response = await client.ExecuteTaskAsync(request);
		}

		public static async Task Delete(int id)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{ApiVersion}");
			RestRequest request = new RestRequest($"/animals/{id}", Method.DELETE);
			request.AddHeader("Content-Type", "application/json");
			IRestResponse response = await client.ExecuteTaskAsync(request);
		}
	}
}