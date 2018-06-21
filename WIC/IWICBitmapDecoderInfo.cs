using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace WIC
{
	[ComImport]
	[Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapDecoderInfo : IWICBitmapCodecInfo
    {
        new WICComponentType GetComponentType();


        new Guid GetCLSID();


        new WICComponentSigning GetSigningStatus();


        new uint GetAuthor([In] [MarshalAs(UnmanagedType.U4)] int cchAuthor, [In] [Out] System.Text.StringBuilder wzAuthor);


        new Guid GetVendorGUID();


        new uint GetVersion([In] [MarshalAs(UnmanagedType.U4)] int cchVersion, [In]  [Out] System.Text.StringBuilder wzVersion);


        new uint GetSpecVersion([In] [MarshalAs(UnmanagedType.U4)] int cchSpecVersion, [In]  [Out] System.Text.StringBuilder wzSpecVersion);


        new uint GetFriendlyName([In] [MarshalAs(UnmanagedType.U4)] int cchFriendlyName, [In]  [Out] System.Text.StringBuilder wzFriendlyName);

        new Guid GetContainerFormat();


        new void GetPixelFormats([In] uint cFormats, [In] [Out] [MarshalAs(UnmanagedType.LPArray)] Guid[] pguidPixelFormats, out uint pcActual);


        new void GetColorManagementVersion([In] [MarshalAs(UnmanagedType.U4)] int cchColorManagementVersion, [In] [Out] StringBuilder wzColorManagementVersion, out uint pcchActual);


        new void GetDeviceManufacturer([In] [MarshalAs(UnmanagedType.U4)] int cchDeviceManufacturer, [In] [Out] StringBuilder wzDeviceManufacturer, out uint pcchActual);


        new void GetDeviceModels([In] [MarshalAs(UnmanagedType.U4)] int cchDeviceModels, [In] [Out] StringBuilder wzDeviceModels, out uint pcchActual);


        new void GetMimeTypes([In] [MarshalAs(UnmanagedType.U4)] int cchMimeTypes, [In] [Out] StringBuilder wzMimeTypes, out uint pcchActual);


        new uint GetFileExtensions([In] [MarshalAs(UnmanagedType.U4)] int cchFileExtensions, [In] [Out] StringBuilder wzFileExtensions);


        [return: MarshalAs(UnmanagedType.Bool)]
        new bool DoesSupportAnimation();


        [return: MarshalAs(UnmanagedType.Bool)]
        new bool DoesSupportChromakey();


        [return: MarshalAs(UnmanagedType.Bool)]
        new bool DoesSupportLossless();


        [return: MarshalAs(UnmanagedType.Bool)]
        new bool DoesSupportMultiframe();


        [return: MarshalAs(UnmanagedType.Bool)]
        new bool MatchesMimeType([In] [MarshalAs(UnmanagedType.LPWStr)] string wzMimeType);


        void GetPatterns(
            uint cbSizePatterns,
            [Out] WICBitmapPattern[] pPatterns,
            out uint pcPatterns,
            out uint pcbPatternsActual);

        [return: MarshalAs(UnmanagedType.Bool)]
        bool MatchesPattern([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICBitmapDecoder CreateInstance();
	}
}
