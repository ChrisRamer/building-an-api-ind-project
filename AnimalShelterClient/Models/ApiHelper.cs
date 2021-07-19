using RestSharp;
using System.Threading.Tasks;

namespace AnimalShelterClient.Models
{
	public class ApiHelper
	{
		static double apiVersion = 1;
		public static double ApiVersion
		{
			get
			{
				return apiVersion;
			}
			set
			{
				apiVersion = value;
			}
		}

		public static async Task<string> GetAll()
		{
			RestClient client = new RestClient($"http://localhost:5004/v{apiVersion}");
			RestRequest request = new RestRequest("/animals", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task<string> Get(int id)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{apiVersion}");
			RestRequest request = new RestRequest($"/animals/{id}", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task Post(string animal)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{apiVersion}");
			RestRequest request = new RestRequest("/animals", Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody(animal);
			IRestResponse response = await client.ExecuteTaskAsync(request);
		}

		public static async Task Put(int id, string animal)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{apiVersion}");
			RestRequest request = new RestRequest($"/animals/{id}", Method.PUT);
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody(animal);
			IRestResponse response = await client.ExecuteTaskAsync(request);
		}

		public static async Task Delete(int id)
		{
			RestClient client = new RestClient($"http://localhost:5004/v{apiVersion}");
			RestRequest request = new RestRequest($"/animals/{id}", Method.DELETE);
			request.AddHeader("Content-Type", "application/json");
			IRestResponse response = await client.ExecuteTaskAsync(request);
		}
	}
}