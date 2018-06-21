using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICBitmapSourceTransform
	{
		
		void CopyPixels([In] ref WICRect prc, [In] uint uiWidth, [In] uint uiHeight, [In] [ComAliasName("WIC.WICPixelFormatGUID")] ref System.Guid pguidDstFormat, [In] WICBitmapTransformOptions dstTransform, [In] uint nStride, [In] uint cbBufferSize, IntPtr pbBuffer);

		
		void GetClosestSize([In] [Out] ref uint puiWidth, [In] [Out] ref uint puiHeight);

		
		void GetClosestPixelFormat([In] [Out] [ComAliasName("WIC.WICPixelFormatGUID")] ref System.Guid pguidDstFormat);

		
        [return: MarshalAs(UnmanagedType.Bool)]
		bool DoesSupportTransform([In] WICBitmapTransformOptions dstTransform);
	}
}
