using System.Net;
using Newtonsoft.Json.Linq;

namespace JPLI
{
	class JPLoader
	{
		JObject root;
		public void APILoad(string reference)
		{
			root = JObject.Parse(new WebClient().DownloadString(reference));
		}
		public string GetData(string key)
		{
			if (root.ContainsKey(key))
				return root[key].ToString();
			else
				return null;
		}
	}
}