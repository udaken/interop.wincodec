using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[Guid("EC5EC8A9-C395-4314-9C77-54D7A935FF70")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICImagingFactory
	{
		
		[return: MarshalAs(UnmanagedType.Interface)]
		IWICBitmapDecoder CreateDecoderFromFilename([In] [MarshalAs(UnmanagedType.LPWStr)] string wzFilename, [In] ref Guid pguidVendor, [In] uint dwDesiredAccess, [In] WICDecodeOptions metadataOptions);

		
		[return: MarshalAs(UnmanagedType.Interface)]
		IWICBitmapDecoder CreateDecoderFromStream([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] ref Guid pguidVendor, [In] WICDecodeOptions metadataOptions);

		
		[return: MarshalAs(UnmanagedType.Interface)]
		IWICBitmapDecoder CreateDecoderFromFileHandle([In] IntPtr hFile, [In] ref Guid pguidVendor, [In] WICDecodeOptions metadataOptions);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICComponentInfo CreateComponentInfo([In] ref Guid clsidComponent);

		
		[return: MarshalAs(UnmanagedType.Interface)]
		IWICBitmapDecoder CreateDecoder([In] ref Guid guidContainerFormat, [In] ref Guid pguidVendor);

		
		[return: MarshalAs(UnmanagedType.Interface)]
		IWICBitmapEncoder CreateEncoder([In] ref Guid guidContainerFormat, [In] ref Guid pguidVendor);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICPalette CreatePalette();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICFormatConverter CreateFormatConverter();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapScaler CreateBitmapScaler();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapClipper CreateBitmapClipper();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapFlipRotator CreateBitmapFlipRotator();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICStream CreateStream();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICColorContext CreateColorContext();

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICColorTransform CreateColorTransformer();

        
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmap CreateBitmap([In] uint uiWidth, [In] uint uiHeight, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid pixelFormat, [In] WICBitmapCreateCacheOption option);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmap CreateBitmapFromSource([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] WICBitmapCreateCacheOption option);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmap CreateBitmapFromSourceRect([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] uint X, [In] uint Y, [In] uint Width, [In] uint Height);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmap CreateBitmapFromMemory([In] uint uiWidth, [In] uint uiHeight, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid pixelFormat, [In] uint cbStride, [In] uint cbBufferSize, [In] IntPtr pbBuffer);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmap CreateBitmapFromHBITMAP([In] IntPtr hBitmap, [In] IntPtr hPalette, [In] WICBitmapAlphaChannelOption options);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmap CreateBitmapFromHICON([In] IntPtr hIcon);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IEnumUnknown CreateComponentEnumerator([In] WICComponentType componentTypes, [In] WICComponentEnumerateOptions options);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICFastMetadataEncoder CreateFastMetadataEncoderFromDecoder([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapDecoder pIDecoder);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICFastMetadataEncoder CreateFastMetadataEncoderFromFrameDecode([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapFrameDecode pIFrameDecoder);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryWriter CreateQueryWriter([In] ref Guid guidMetadataFormat, [In] ref Guid pguidVendor);

		
		[return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryWriter CreateQueryWriterFromReader([In] [MarshalAs(UnmanagedType.Interface)] IWICMetadataQueryReader pIQueryReader, [In] ref Guid pguidVendor);
	}
}
