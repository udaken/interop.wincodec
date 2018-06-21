using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000301-A8F2-4877-BA0A-FD2B6645FB94")]
	public interface IWICFormatConverter : IWICBitmapSource
    {

        new void GetSize(out uint puiWidth, out uint puiHeight);


        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        new System.Guid GetPixelFormat();


        new void GetResolution(out double pDpiX, out double pDpiY);


        new void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        new void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);


        void Initialize([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pISource, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid dstFormat, [In] WICBitmapDitherType dither, [In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette, [In] double alphaThresholdPercent, [In] WICBitmapPaletteType paletteTranslate);

		
        [return: MarshalAs(UnmanagedType.Bool)]
		bool CanConvert([In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid srcPixelFormat, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid dstPixelFormat);
	}
}
