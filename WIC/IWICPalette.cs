using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
    public interface IWICPalette
    {

        void InitializePredefined([In] WICBitmapPaletteType ePaletteType, [In] [MarshalAs(UnmanagedType.Bool)] bool fAddTransparentColor);


        void InitializeCustom([In] ref uint pColors, [In] uint cCount);


        void InitializeFromBitmap([In] [MarshalAs(UnmanagedType.Interface)] IWICBitmapSource pISurface, [In] uint cCount, [In] [MarshalAs(UnmanagedType.Bool)] bool fAddTransparentColor);


        void InitializeFromPalette([In] [MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette);


        WICBitmapPaletteType GetType();


        uint GetColorCount();


        uint GetColors([In] uint cCount, out uint pColors);


        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsBlackWhite();


        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsGrayscale();


        [return: MarshalAs(UnmanagedType.Bool)]
        bool HasAlpha();
    }
}
