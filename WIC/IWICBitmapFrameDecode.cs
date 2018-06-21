using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3B16811B-6A43-4EC9-A813-3D930C13B940")]
	public interface IWICBitmapFrameDecode : IWICBitmapSource
    {
        #region IWICBitmapSource
        new void GetSize(out uint puiWidth, out uint puiHeight);


        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        new System.Guid GetPixelFormat();


        new void GetResolution(out double pDpiX, out double pDpiY);


        new void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        new void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);
        #endregion

        #region IWICBitmapFrameDecode

        [return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryReader GetMetadataQueryReader();

		
		void GetColorContexts([In] uint cCount, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref IWICColorContext ppIColorContexts, out uint pcActualCount);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapSource GetThumbnail();
        #endregion
    }
}
