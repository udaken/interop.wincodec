using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("E8EDA601-3D48-431A-AB44-69059BE88BBE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICPixelFormatInfo : IWICComponentInfo
    {
        #region IWICComponentInfo
        new WICComponentType GetComponentType();


        new Guid GetCLSID();


        new WICComponentSigning GetSigningStatus();


        new uint GetAuthor([In] [MarshalAs(UnmanagedType.U4)] int cchAuthor, [In] [Out] System.Text.StringBuilder wzAuthor);


        new Guid GetVendorGUID();


        new uint GetVersion([In] [MarshalAs(UnmanagedType.U4)] int cchVersion, [In]  [Out] System.Text.StringBuilder wzVersion);


        new uint GetSpecVersion([In] [MarshalAs(UnmanagedType.U4)] int cchSpecVersion, [In]  [Out] System.Text.StringBuilder wzSpecVersion);


        new uint GetFriendlyName([In] [MarshalAs(UnmanagedType.U4)] int cchFriendlyName, [In]  [Out] System.Text.StringBuilder wzFriendlyName);
        #endregion

        Guid GetFormatGUID();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICColorContext GetColorContext();

		
        uint GetBitsPerPixel();

		
        uint GetChannelCount();

		
        uint GetChannelMask([In] uint uiChannelIndex, [In] uint cbMaskBuffer, [In] [Out] IntPtr pbMaskBuffer);
	}
}
