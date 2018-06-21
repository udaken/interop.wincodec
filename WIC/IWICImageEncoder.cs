using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
	[ComConversionLoss]
	public interface IWICImageEncoder
	{
		
		void WriteFrame([In] IntPtr pImage, [In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapFrameEncode pFrameEncode, [In] ref WICImageParameters pImageParameters);

		
		void WriteFrameThumbnail([In] IntPtr pImage, [In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapFrameEncode pFrameEncode, [In] ref WICImageParameters pImageParameters);

		
		void WriteThumbnail([In] IntPtr pImage, [In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapEncoder pEncoder, [In] ref WICImageParameters pImageParameters);
	}
}
