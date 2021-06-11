using System;
using System.Collections.Generic;
using System.Text;

namespace CefNet.DevTools.Protocol.Internal
{
	internal sealed class EventProxy<T> : IEventProxy
	{
		private event EventHandler<T> _handlers;
		private Func<string, T> _convert;

		public EventProxy(EventHandler<T> handler, Func<string, T> convert)
		{
			_handlers += handler;
			_convert = convert;
		}

		public void AddHandler(EventHandler<T> handler)
		{
			_handlers += handler;
		}

		public void RemoveHandler(EventHandler<T> handler)
		{
			_handlers -= handler;
		}

		public void Raise(object sender, string json)
		{
			_handlers?.Invoke(sender, _convert(json));
		}
	}
}
