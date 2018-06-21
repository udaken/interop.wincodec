using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("0000000D-0000-0000-C000-000000000046")]
    public interface IEnumSTATSTG
    {
        [PreserveSig]
        int Next([In] uint celt, [Out] System.Runtime.InteropServices.ComTypes.STATSTG[] rgelt, out uint pceltFetched);

        [PreserveSig]
        int Skip([In] uint celt);


        void Reset();


        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumSTATSTG Clone();
    }
}
