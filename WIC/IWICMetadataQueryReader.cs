using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[Guid("30989668-E1C9-4597-B395-458EEDB808DF")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICMetadataQueryReader
	{

        Guid GetContainerFormat();

		
		int GetLocation([In] uint cchMaxLength, [In] [Out] System.Text.StringBuilder wzNamespace);

		
		void GetMetadataByName([In] [MarshalAs(UnmanagedType.LPWStr)] string wzName, [In] [Out] ref PROPVARIANT pvarValue);

        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumString GetEnumerator();
	}
}
