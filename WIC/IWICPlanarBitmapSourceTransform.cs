using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICPlanarBitmapSourceTransform
	{
		
        [return: MarshalAs(UnmanagedType.Bool)]
		bool DoesSupportTransform([In] [Out] ref uint puiWidth, [In] [Out] ref uint puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [In] [ComAliasName("WIC.WICPixelFormatGUID")] ref System.Guid pguidDstFormats, out WICBitmapPlaneDescription pPlaneDescriptions, uint cPlanes);

		
		void CopyPixels([In] ref WICRect prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [In] ref WICBitmapPlane pDstPlanes, uint cPlanes);
	}
}
