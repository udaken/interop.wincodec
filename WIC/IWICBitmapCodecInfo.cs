using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace WIC
{
	[ComImport]
	[Guid("E87A44C4-B76E-4C47-8B09-298EB12A2714")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapCodecInfo : IWICComponentInfo
    {

        new WICComponentType GetComponentType();


        new Guid GetCLSID();


        new WICComponentSigning GetSigningStatus();


        new uint GetAuthor([In] [MarshalAs(UnmanagedType.U4)] int cchAuthor, [In] [Out] System.Text.StringBuilder wzAuthor);


        new Guid GetVendorGUID();


        new uint GetVersion([In] [MarshalAs(UnmanagedType.U4)] int cchVersion, [In]  [Out] System.Text.StringBuilder wzVersion);


        new uint GetSpecVersion([In] [MarshalAs(UnmanagedType.U4)] int cchSpecVersion, [In]  [Out] System.Text.StringBuilder wzSpecVersion);


        new uint GetFriendlyName([In] [MarshalAs(UnmanagedType.U4)] int cchFriendlyName, [In]  [Out] System.Text.StringBuilder wzFriendlyName);


        Guid GetContainerFormat();

		
		void GetPixelFormats([In] uint cFormats, [In] [Out] [MarshalAs(UnmanagedType.LPArray)] Guid[] pguidPixelFormats, out uint pcActual);

		
		void GetColorManagementVersion([In] [MarshalAs(UnmanagedType.U4)] int cchColorManagementVersion, [In] [Out] StringBuilder wzColorManagementVersion, out uint pcchActual);

		
		void GetDeviceManufacturer([In] [MarshalAs(UnmanagedType.U4)] int cchDeviceManufacturer, [In] [Out] StringBuilder wzDeviceManufacturer, out uint pcchActual);

		
		void GetDeviceModels([In] [MarshalAs(UnmanagedType.U4)] int cchDeviceModels, [In] [Out] StringBuilder wzDeviceModels, out uint pcchActual);

		
		void GetMimeTypes([In] [MarshalAs(UnmanagedType.U4)] int cchMimeTypes, [In] [Out] StringBuilder wzMimeTypes, out uint pcchActual);

		
		uint GetFileExtensions([In] [MarshalAs(UnmanagedType.U4)] int cchFileExtensions, [In] [Out] StringBuilder wzFileExtensions);

		
        [return: MarshalAs(UnmanagedType.Bool)]
        bool DoesSupportAnimation();

        
        [return: MarshalAs(UnmanagedType.Bool)]
        bool DoesSupportChromakey();

        
        [return: MarshalAs(UnmanagedType.Bool)]
        bool DoesSupportLossless();

        
        [return: MarshalAs(UnmanagedType.Bool)]
		bool DoesSupportMultiframe();

		
        [return: MarshalAs(UnmanagedType.Bool)]
        bool MatchesMimeType([In] [MarshalAs(UnmanagedType.LPWStr)] string wzMimeType);
	}
}
