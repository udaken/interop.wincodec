using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("95C75A6E-3E8C-4EC2-85A8-AEBCC551E59B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICDevelopRawNotificationCallback
	{
		
		void Notify([In] uint NotificationMask);
	}
}
