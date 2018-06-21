using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("B66F034F-D0E2-40AB-B436-6DE39E321A94")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICColorTransform : IWICBitmapSource
    {

        new void GetSize(out uint puiWidth, out uint puiHeight);


        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        new System.Guid GetPixelFormat();


        new void GetResolution(out double pDpiX, out double pDpiY);


        new void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        new void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);


        void Initialize([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] [MarshalAs(UnmanagedType.Interface)] IWICColorContext pIContextSource, [In] [MarshalAs(UnmanagedType.Interface)] IWICColorContext pIContextDest, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid pixelFmtDest);
	}
}
