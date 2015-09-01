using Newtonsoft.Json;

namespace Experiments
{
	public static class ObjectExtensions
	{
		public static string ToJson(this object obj, bool format = false)
		{
			if (format)
			{
				return JsonConvert.SerializeObject(obj, Formatting.Indented);
			}

			return JsonConvert.SerializeObject(obj);
		}
	}
}
