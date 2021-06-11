using System.Text.Json;

namespace CefNet.DevTools.Protocol.Internal
{
	internal sealed class LowerCaseNamingPolicy : JsonNamingPolicy
	{
		public override string ConvertName(string name)
		{
			return name.ToLowerInvariant();
		}
	}
}
