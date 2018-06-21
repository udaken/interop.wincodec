using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
    [ComImport]
    [Guid("00000100-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumUnknown
    {
        [PreserveSig]
        int Next([In] uint celt, [Out] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] object[] rgelt, out uint pceltFetched);

        [PreserveSig]
        int Skip([In] uint celt);


        void Reset();


        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumUnknown Clone();
    }
}
