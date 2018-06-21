using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapDecoder
	{

        WICBitmapDecoderCapabilities QueryCapability([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream);

		
		void Initialize([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] WICDecodeOptions cacheOptions);

		
        Guid GetContainerFormat();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapDecoderInfo GetDecoderInfo();

		
		void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryReader GetMetadataQueryReader();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapSource GetPreview();

		
		void GetColorContexts([In] uint cCount, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref IWICColorContext ppIColorContexts, out uint pcActualCount);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapSource GetThumbnail();

		
        uint GetFrameCount();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapFrameDecode GetFrame([In] uint index);
	}
}
