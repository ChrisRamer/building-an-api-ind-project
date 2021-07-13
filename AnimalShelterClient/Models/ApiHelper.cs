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
			RestClient client = new RestClient("http://localhost:5004");
			RestRequest request = new RestRequest($"v{apiVersion}/animals", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task<string> Get(int id)
		{
			RestClient client = new RestClient("http://localhost:5004");
			RestRequest request = new RestRequest($"v{apiVersion}/animals/{id}", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}
	}
}