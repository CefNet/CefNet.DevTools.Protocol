using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Xilium.Crdtp.Client.Serialization
{
	internal abstract class StjSerializerOptions
	{
		protected abstract ICollection<JsonConverter> GetConvertersCore();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ICollection<JsonConverter> GetConverters()
		{
			return GetConvertersCore();
		}
	}
}