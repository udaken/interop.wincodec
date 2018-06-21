using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("00000120-A8F2-4877-BA0A-FD2B6645FB94")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapSource
	{
		
		void GetSize(out uint puiWidth, out uint puiHeight);

		
        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        System.Guid GetPixelFormat();

		
		void GetResolution(out double pDpiX, out double pDpiY);

		
		void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);

		
		void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);
	}
}
