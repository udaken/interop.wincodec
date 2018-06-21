using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("23BC3F0A-698B-4357-886B-F24D50671334")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICComponentInfo
	{

        WICComponentType GetComponentType();

		
        Guid GetCLSID();


        WICComponentSigning GetSigningStatus();

		
		uint GetAuthor([In] [MarshalAs(UnmanagedType.U4)] int cchAuthor,[In] [Out] System.Text.StringBuilder wzAuthor);


        Guid GetVendorGUID();

		
		uint GetVersion([In] [MarshalAs(UnmanagedType.U4)] int cchVersion, [In]  [Out] System.Text.StringBuilder wzVersion);

		
		uint GetSpecVersion([In] [MarshalAs(UnmanagedType.U4)] int cchSpecVersion, [In]  [Out] System.Text.StringBuilder wzSpecVersion);

		
		uint GetFriendlyName([In] [MarshalAs(UnmanagedType.U4)] int cchFriendlyName, [In]  [Out] System.Text.StringBuilder wzFriendlyName);
	}
}
