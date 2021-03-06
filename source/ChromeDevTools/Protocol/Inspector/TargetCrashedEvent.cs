using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Fired when debugging target has crashed
	/// </summary>
	[Event(ProtocolName.Inspector.TargetCrashed)]
	public class TargetCrashedEvent
	{
	}
}
