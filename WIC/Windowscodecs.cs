using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WIC
{
    public static class Windowscodecs
    {
        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void ConvertBitmapSource(
          [ComAliasName("REFWICPixelFormatGUID")]
          [In] Guid dstFormat,
          [MarshalAs(UnmanagedType.Interface)]
          [In] IWICBitmapSource      pISrc,
          [MarshalAs(UnmanagedType.Interface)]
          [Out] out IWICBitmapSource      ppIDst
        );

        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void CreateBitmapFromSection(
          uint width,
          uint height,
          [ComAliasName("REFWICPixelFormatGUID")]
          [In] Guid pixelFormat,
          IntPtr hSection,
          uint stride,
          uint offset,
          [Out] out IWICBitmap pIBitmap
        );
        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void CreateBitmapFromSectionEx(
          uint width,
          uint height,
          [ComAliasName("REFWICPixelFormatGUID")]
          [In] Guid pixelFormat,
          IntPtr hSection,
          uint stride,
          uint offset,
          WICSectionAccessLevel desiredAccessLevel,
          [Out] out IWICBitmap pIBitmap
        );
#if false
        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void GetMetadataContentSize(
          [In] Guid guidContainerFormat,
          [In] IWICMetadataWriter pIWriter,
          [Out] out ulong pcbSize
        );
#endif
        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void MapGuidToShortName(
          [In] Guid guid,
          uint cchName,
          [In][Out] StringBuilder wzName,
          out uint pcchActual
        );

        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void MapSchemaToName(
          [In] Guid guidMetadataFormat,
          string pwzSchema,
          uint cchName,
          [In][Out] StringBuilder wzName,
          out uint pcchActual
        );

        [DllImport("Windowscodecs.dll", BestFitMapping = true, PreserveSig = false)]
        public extern static void MapShortNameToGuid(
          string wzName,
          [Out] out Guid pguid
        );
    }
}
