using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
	public interface IWICMetadataQueryWriter : IWICMetadataQueryReader
    {
        #region IWICMetadataQueryReader
        new Guid GetContainerFormat();


        new int GetLocation([In] uint cchMaxLength, [In] [Out] System.Text.StringBuilder wzNamespace);


        new void GetMetadataByName([In] [MarshalAs(UnmanagedType.LPWStr)] string wzName, [In] [Out] ref PROPVARIANT pvarValue);

        [return: MarshalAs(UnmanagedType.Interface)]
        new IEnumString GetEnumerator();
        #endregion

        void SetMetadataByName([In] [MarshalAs(UnmanagedType.LPWStr)] string wzName, [In] ref PROPVARIANT pvarValue);

		
		void RemoveMetadataByName([In] [MarshalAs(UnmanagedType.LPWStr)] string wzName);
	}
}
