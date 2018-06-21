using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("E4FBCF03-223D-4E81-9333-D635556DD1B5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapClipper : IWICBitmapSource
    {

        new void GetSize(out uint puiWidth, out uint puiHeight);


        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        new System.Guid GetPixelFormat();


        new void GetResolution(out double pDpiX, out double pDpiY);


        new void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        new void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);


        void Initialize([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pISource, [In] ref WICRect prc);
	}
}
