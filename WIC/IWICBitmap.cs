using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
	public interface IWICBitmap : IWICBitmapSource
    {

        new void GetSize(out uint puiWidth, out uint puiHeight);


        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        new System.Guid GetPixelFormat();


        new void GetResolution(out double pDpiX, out double pDpiY);


        new void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        new void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);


        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapLock Lock([In] ref WICRect prcLock, [In] WICBitmapLockFlags flags);

		
		void SetPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);

		
		void SetResolution([In] double dpiX, [In] double dpiY);
	}
}
