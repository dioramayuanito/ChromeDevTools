using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Executes <code>querySelectorAll</code> on a given node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.QuerySelectorAll)]
	public class QuerySelectorAllCommandResponse
	{
		/// <summary>
		/// Gets or sets Query selector result.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
