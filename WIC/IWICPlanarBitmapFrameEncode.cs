using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F928B7B8-2221-40C1-B72E-7E82F1974D1A")]
	public interface IWICPlanarBitmapFrameEncode
	{
		
		void WritePixels(uint lineCount, [In] ref WICBitmapPlane pPlanes, uint cPlanes);

		
		void WriteSource([In] [MarshalAs(UnmanagedType.Interface)] ref IWICBitmapSource ppPlanes, uint cPlanes, [In] ref WICRect prcSource);
	}
}
