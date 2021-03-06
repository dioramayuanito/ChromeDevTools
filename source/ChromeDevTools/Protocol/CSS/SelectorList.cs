using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Selector list data.
	/// </summary>
	public class SelectorList
	{
		/// <summary>
		/// Gets or sets Selectors in the list.
		/// </summary>
		public Selector[] Selectors { get; set; }
		/// <summary>
		/// Gets or sets Rule selector text.
		/// </summary>
		public string Text { get; set; }
	}
}
