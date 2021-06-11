using System.Text.Json;

namespace CefNet.DevTools.Protocol.Internal
{
	internal sealed class LowerCamelCaseNamingPolicy : JsonNamingPolicy
	{
		public override string ConvertName(string name)
		{
			return name.Length > 1 ? char.ToLowerInvariant(name[0]) + name.Substring(1) : name.ToLowerInvariant();
		}
	}
}
