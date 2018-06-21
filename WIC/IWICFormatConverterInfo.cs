using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9F34FB65-13F4-4F15-BC57-3726B5E53D9F")]
	public interface IWICFormatConverterInfo : IWICComponentInfo
    {

        new WICComponentType GetComponentType();


        new Guid GetCLSID();


        new WICComponentSigning GetSigningStatus();


        new uint GetAuthor([In] [MarshalAs(UnmanagedType.U4)] int cchAuthor, [In] [Out] System.Text.StringBuilder wzAuthor);


        new Guid GetVendorGUID();


        new uint GetVersion([In] [MarshalAs(UnmanagedType.U4)] int cchVersion, [In]  [Out] System.Text.StringBuilder wzVersion);


        new uint GetSpecVersion([In] [MarshalAs(UnmanagedType.U4)] int cchSpecVersion, [In]  [Out] System.Text.StringBuilder wzSpecVersion);


        new uint GetFriendlyName([In] [MarshalAs(UnmanagedType.U4)] int cchFriendlyName, [In]  [Out] System.Text.StringBuilder wzFriendlyName);


        void GetPixelFormats([In] uint cFormats, [In] [Out] [ComAliasName("WIC.WICPixelFormatGUID")] ref System.Guid pPixelFormatGUIDs, out uint pcActual);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICFormatConverter CreateInstance();
	}
}
