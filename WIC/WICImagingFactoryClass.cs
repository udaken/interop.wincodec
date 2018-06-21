using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace WIC
{
    [ComImport]
    [TypeLibType(TypeLibTypeFlags.FCanCreate)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("cacaf262-9370-4615-a13b-9f5539da4c0a")]
    public class WICImagingFactoryClass : IWICImagingFactory
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapDecoder CreateDecoderFromFilename([In, MarshalAs(UnmanagedType.LPWStr)] string wzFilename, [In] ref Guid pguidVendor, [In] uint dwDesiredAccess, [In] WICDecodeOptions metadataOptions);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapDecoder CreateDecoderFromStream([In, MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] ref Guid pguidVendor, [In] WICDecodeOptions metadataOptions);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapDecoder CreateDecoderFromFileHandle([In] IntPtr hFile, [In] ref Guid pguidVendor, [In] WICDecodeOptions metadataOptions);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICComponentInfo CreateComponentInfo([In] ref Guid clsidComponent);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapDecoder CreateDecoder([In] ref Guid guidContainerFormat, [In] ref Guid pguidVendor);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapEncoder CreateEncoder([In] ref Guid guidContainerFormat, [In] [Optional]ref Guid pguidVendor);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICPalette CreatePalette();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICFormatConverter CreateFormatConverter();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapScaler CreateBitmapScaler();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapClipper CreateBitmapClipper();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmapFlipRotator CreateBitmapFlipRotator();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICStream CreateStream();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICColorContext CreateColorContext();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICColorTransform CreateColorTransformer();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmap CreateBitmap([In] uint uiWidth, [In] uint uiHeight, [In] ref Guid pixelFormat, [In] WICBitmapCreateCacheOption option);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmap CreateBitmapFromSource([In, MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] WICBitmapCreateCacheOption option);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmap CreateBitmapFromSourceRect([In, MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pIBitmapSource, [In] uint X, [In] uint Y, [In] uint Width, [In] uint Height);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmap CreateBitmapFromMemory([In] uint uiWidth, [In] uint uiHeight, [In] ref Guid pixelFormat, [In] uint cbStride, [In] uint cbBufferSize, [In] IntPtr pbBuffer);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmap CreateBitmapFromHBITMAP([In] IntPtr hBitmap, [In] IntPtr hPalette, [In] WICBitmapAlphaChannelOption options);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICBitmap CreateBitmapFromHICON([In] IntPtr hIcon);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IEnumUnknown CreateComponentEnumerator([In] WICComponentType componentTypes, [In] WICComponentEnumerateOptions options);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICFastMetadataEncoder CreateFastMetadataEncoderFromDecoder([In, MarshalAs(UnmanagedType.Interface)] IWICBitmapDecoder pIDecoder);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICFastMetadataEncoder CreateFastMetadataEncoderFromFrameDecode([In, MarshalAs(UnmanagedType.Interface)] IWICBitmapFrameDecode pIFrameDecoder);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICMetadataQueryWriter CreateQueryWriter([In] ref Guid guidMetadataFormat, [In] ref Guid pguidVendor);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public extern IWICMetadataQueryWriter CreateQueryWriterFromReader([In, MarshalAs(UnmanagedType.Interface)] IWICMetadataQueryReader pIQueryReader, [In] ref Guid pguidVendor);
    }
}
