using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("64C1024E-C3CF-4462-8078-88C2B11C46D9")]
	public interface IWICBitmapCodecProgressNotification
	{
		
		void Remote_RegisterProgressNotification([In] [MarshalAs(UnmanagedType.Interface)] IWICProgressCallback pICallback, [In] uint dwProgressFlags);
	}
}
