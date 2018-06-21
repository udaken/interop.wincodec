using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComConversionLoss]
	[Guid("7B816B45-1996-4476-B132-DE9E247C8AF0")]
	public interface IWICImagingFactory2 : IWICImagingFactory
    {
        #region IWICImagingFactory
        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapDecoder CreateDecoderFromFilename([In] [MarshalAs(UnmanagedType.LPWStr)] string wzFilename, [In] ref Guid pguidVendor, [In] uint dwDesiredAccess, [In] WICDecodeOptions metadataOptions);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapDecoder CreateDecoderFromStream([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] ref Guid pguidVendor, [In] WICDecodeOptions metadataOptions);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapDecoder CreateDecoderFromFileHandle([In] IntPtr hFile, [In] ref Guid pguidVendor, [In] WICDecodeOptions metadataOptions);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICComponentInfo CreateComponentInfo([In] ref Guid clsidComponent);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapDecoder CreateDecoder([In] ref Guid guidContainerFormat, [In] ref Guid pguidVendor);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapEncoder CreateEncoder([In] ref Guid guidContainerFormat, [In] ref Guid pguidVendor);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICPalette CreatePalette();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICFormatConverter CreateFormatConverter();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapScaler CreateBitmapScaler();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapClipper CreateBitmapClipper();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapFlipRotator CreateBitmapFlipRotator();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICStream CreateStream();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICColorContext CreateColorContext();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICColorTransform CreateColorTransformer();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmap CreateBitmap([In] uint uiWidth, [In] uint uiHeight, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid pixelFormat, [In] WICBitmapCreateCacheOption option);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmap CreateBitmapFromSource([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] WICBitmapCreateCacheOption option);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmap CreateBitmapFromSourceRect([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] uint X, [In] uint Y, [In] uint Width, [In] uint Height);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmap CreateBitmapFromMemory([In] uint uiWidth, [In] uint uiHeight, [In] [ComAliasName("WIC.REFWICPixelFormatGUID")] ref Guid pixelFormat, [In] uint cbStride, [In] uint cbBufferSize, [In] IntPtr pbBuffer);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmap CreateBitmapFromHBITMAP([In] IntPtr hBitmap, [In] IntPtr hPalette, [In] WICBitmapAlphaChannelOption options);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmap CreateBitmapFromHICON([In] IntPtr hIcon);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IEnumUnknown CreateComponentEnumerator([In] WICComponentType componentTypes, [In] WICComponentEnumerateOptions options);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICFastMetadataEncoder CreateFastMetadataEncoderFromDecoder([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapDecoder pIDecoder);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICFastMetadataEncoder CreateFastMetadataEncoderFromFrameDecode([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapFrameDecode pIFrameDecoder);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICMetadataQueryWriter CreateQueryWriter([In] ref Guid guidMetadataFormat, [In] ref Guid pguidVendor);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICMetadataQueryWriter CreateQueryWriterFromReader([In] [MarshalAs(UnmanagedType.Interface)] IWICMetadataQueryReader pIQueryReader, [In] ref Guid pguidVendor);
#endregion

        [return: MarshalAs(UnmanagedType.Interface)]
        IWICImageEncoder CreateImageEncoder([In] IntPtr pD2DDevice);
	}
}
