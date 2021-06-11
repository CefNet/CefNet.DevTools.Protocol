using System;
using System.Collections.Generic;
using System.Text;

namespace CefNet.DevTools
{
	public interface IEventProxy
	{
		void Raise(object sender, string json);
	}
}
