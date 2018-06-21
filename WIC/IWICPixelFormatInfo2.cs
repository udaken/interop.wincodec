using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
	public interface IWICPixelFormatInfo2 : IWICPixelFormatInfo
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

        #region IWICPixelFormatInfo
        new Guid GetFormatGUID();


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICColorContext GetColorContext();


        new uint GetBitsPerPixel();


        new uint GetChannelCount();


        new uint GetChannelMask([In] uint uiChannelIndex, [In] uint cbMaskBuffer, [In] [Out] IntPtr pbMaskBuffer);
        #endregion

        [return: MarshalAs(UnmanagedType.Bool)]
		bool SupportsTransparency();

        
        WICPixelFormatNumericRepresentation GetNumericRepresentation();
	}
}
