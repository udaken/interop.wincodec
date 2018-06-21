using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
	public interface IWICBitmapFrameEncode
	{
		
		void Initialize([In] [MarshalAs(UnmanagedType.Interface)] IPropertyBag2 pIEncoderOptions);

		
		void SetSize([In] uint uiWidth, [In] uint uiHeight);

		
		void SetResolution([In] double dpiX, [In] double dpiY);

		
		void SetPixelFormat([In] [Out] [ComAliasName("WIC.WICPixelFormatGUID")] ref System.Guid pPixelFormat);

		
		void SetColorContexts([In] uint cCount, [In] [MarshalAs(UnmanagedType.Interface)] ref IWICColorContext ppIColorContext);

		
		void SetPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);

		
		void SetThumbnail([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIThumbnail);

		
		void WritePixels([In] uint lineCount, [In] uint cbStride, [In] uint cbBufferSize, [In] IntPtr pbPixels);

		
		void WriteSource([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] ref WICRect prc);

		
		void Commit();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryWriter GetMetadataQueryWriter();
	}
}
