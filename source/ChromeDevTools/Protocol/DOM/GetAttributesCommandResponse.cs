using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetAttributes)]
	public class GetAttributesCommandResponse
	{
		/// <summary>
		/// Gets or sets An interleaved array of node attribute names and values.
		/// </summary>
		public string[] Attributes { get; set; }
	}
}
