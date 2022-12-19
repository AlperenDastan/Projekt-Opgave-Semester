using Projekt_Opgave.Models;
using System.Text.Json;

namespace Projekt_Opgave.Service
{
	public class JsonFileServiceOrder
	{
		public IWebHostEnvironment WebHostEnvironment { get; }

		public JsonFileServiceOrder(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		private string JsonFileName
		{
			get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Orders.json"); }
		}

		public void SaveJsonItems(List<OrderModel> order)
		{
			using (FileStream jsonFileWriter = File.Create(JsonFileName))
			{
				Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
				{
					SkipValidation = false,
					Indented = true
				});
				JsonSerializer.Serialize<OrderModel[]>(jsonWriter, order.ToArray());
			}
		}

		public IEnumerable<OrderModel> GetJsonItems()
		{
			using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
			{
				return JsonSerializer.Deserialize<OrderModel[]>(jsonFileReader.ReadToEnd());
			}
		}
	}
}
