using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapEncoder
	{
		
		void Initialize([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] WICBitmapEncoderCacheOption cacheOption);

		
        Guid GetContainerFormat();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapEncoderInfo GetEncoderInfo();

		
		void SetColorContexts([In] uint cCount, [In] [MarshalAs(UnmanagedType.Interface)] ref IWICColorContext ppIColorContext);

		
		void SetPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);

		
		void SetThumbnail([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIThumbnail);

		
		void SetPreview([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIPreview);

		
		void CreateNewFrame([MarshalAs(UnmanagedType.Interface)] out IWICBitmapFrameEncode ppIFrameEncode, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref IPropertyBag2 ppIEncoderOptions);

		
		void Commit();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryWriter GetMetadataQueryWriter();
	}
}
