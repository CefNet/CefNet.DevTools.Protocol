using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using CefNet.DevTools.Protocol.Internal;
using System.Collections.Generic;
using CefNet.DevTools.Protocol;

namespace CefNet.DevTools
{
	public abstract class CrdtpSession
	{
		private ProtocolStjSerializerOptions _options;
		private JsonSerializerOptions _jsonSerializerOptions;
		private readonly Dictionary<string, IEventProxy> _events = new Dictionary<string, IEventProxy>();


		public abstract Task ExecuteCommandAsync<T>(string command, T parameters, CancellationToken cancellationToken) where T: class;
		public abstract Task<TResponse> ExecuteCommandAsync<TRequest, TResponse>(string command, TRequest parameters, CancellationToken cancellationToken) 
			where TRequest : class 
			where TResponse: class;
		
		public virtual void AddEventHandler<T>(string eventName, EventHandler<T> handler)
			where T : class
		{
			lock (_events)
			{
				if (_events.TryGetValue(eventName, out IEventProxy eventProxy))
				{
					((EventProxy<T>)eventProxy).AddHandler(handler);
				}
				else
				{
					eventProxy = new EventProxy<T>(handler, ConvertJsonToType<T>);
					_events.Add(eventName, eventProxy);
				}
			}
		}

		public virtual void RemoveEventHandler<T>(string eventName, EventHandler<T> handler)
			where T : class
		{
			lock (_events)
			{
				if (_events.TryGetValue(eventName, out IEventProxy eventProxy))
				{
					((EventProxy<T>)eventProxy).RemoveHandler(handler);
				}
			}
		}

		internal void UseSerializerOptions(ProtocolStjSerializerOptions options)
		{
			_options = options;
		}

		protected virtual JsonSerializerOptions GetJsonSerializerOptions()
		{
			if (_jsonSerializerOptions is null)
			{
				var namingPolicy = new LowerCamelCaseNamingPolicy();
				_jsonSerializerOptions = new JsonSerializerOptions
				{
					DictionaryKeyPolicy = namingPolicy,
					PropertyNamingPolicy = namingPolicy,
					DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
				};

				if (_options is null)
					return _jsonSerializerOptions;

				foreach (JsonConverter converter in _options.GetConverters())
				{
					_jsonSerializerOptions.Converters.Add(converter);
				}
			}
			return _jsonSerializerOptions;
		}

		protected virtual IEventProxy GetEventProxy(string eventName)
		{
			lock (_events)
			{
				if (_events.TryGetValue(eventName, out IEventProxy eventProxy))
					return eventProxy;
			}
			return null;
		}

		private T ConvertJsonToType<T>(string json)
			where T : class
		{
			return JsonSerializer.Deserialize<T>(json, GetJsonSerializerOptions());
		}
	}
}





