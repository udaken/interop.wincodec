using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[ComConversionLoss]
	[Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICDevelopRaw : IWICBitmapFrameDecode
    {
        #region IWICBitmapSource
        new void GetSize(out uint puiWidth, out uint puiHeight);


        [return: ComAliasName("WIC.WICPixelFormatGUID"), MarshalAs(UnmanagedType.LPStruct)]
        new System.Guid GetPixelFormat();


        new void GetResolution(out double pDpiX, out double pDpiY);


        new void CopyPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        new void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, IntPtr pbBuffer);
        #endregion

        #region IWICBitmapFrameDecode

        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICMetadataQueryReader GetMetadataQueryReader();


        new void GetColorContexts([In] uint cCount, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref IWICColorContext ppIColorContexts, out uint pcActualCount);


        [return: MarshalAs(UnmanagedType.Interface)]
        new IWICBitmapSource GetThumbnail();
        #endregion

        void Remote_QueryRawCapabilitiesInfo([In] [Out] ref WICRawCapabilitiesInfo pInfo);

		
		void LoadParameterSet([In] WICRawParameterSet ParameterSet);

		
		void GetCurrentParameterSet([MarshalAs(UnmanagedType.Interface)] out IPropertyBag2 ppCurrentParameterSet);

		
		void SetExposureCompensation([In] double ev);

		
		void GetExposureCompensation(out double pEV);

		
		void SetWhitePointRGB([In] uint Red, [In] uint Green, [In] uint Blue);

		
		void GetWhitePointRGB(out uint pRed, out uint pGreen, out uint pBlue);

		
		void SetNamedWhitePoint([In] WICNamedWhitePoint WhitePoint);

		
		void GetNamedWhitePoint(out WICNamedWhitePoint pWhitePoint);

		
		void SetWhitePointKelvin([In] uint WhitePointKelvin);

		
		void GetWhitePointKelvin(out uint pWhitePointKelvin);

		
		void GetKelvinRangeInfo(out uint pMinKelvinTemp, out uint pMaxKelvinTemp, out uint pKelvinTempStepValue);

		
		void SetContrast([In] double Contrast);

		
		void GetContrast(out double pContrast);

		
		void SetGamma([In] double Gamma);

		
		void GetGamma(out double pGamma);

		
		void SetSharpness([In] double Sharpness);

		
		void GetSharpness(out double pSharpness);

		
		void SetSaturation([In] double Saturation);

		
		void GetSaturation(out double pSaturation);

		
		void SetTint([In] double Tint);

		
		void GetTint(out double pTint);

		
		void SetNoiseReduction([In] double NoiseReduction);

		
		void GetNoiseReduction(out double pNoiseReduction);

		
		void SetDestinationColorContext([In] [MarshalAs(UnmanagedType.Interface)] IWICColorContext pColorContext);

		
		void Remote_SetToneCurve([In] uint cPoints, [In] ref WICRawToneCurvePoint aPoints);

		
		void Remote_GetToneCurve(out uint pcPoints, [Out] IntPtr paPoints);

		
		void SetRotation([In] double Rotation);

		
		void GetRotation(out double pRotation);

		
		void SetRenderMode([In] WICRawRenderMode RenderMode);

		
		void GetRenderMode(out WICRawRenderMode pRenderMode);

		
		void SetNotificationCallback([In] [MarshalAs(UnmanagedType.Interface)] IWICDevelopRawNotificationCallback pCallback);
	}
}
