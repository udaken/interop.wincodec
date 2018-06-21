using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
	public interface IPropertyBag2
	{
		
		void Read([In] uint cProperties, [In] ref PROPBAG2 pPropBag, [In] [MarshalAs(UnmanagedType.Interface)] IErrorLog pErrLog, [MarshalAs(UnmanagedType.Struct)] out object pvarValue, [In] [Out] [MarshalAs(UnmanagedType.Error)] ref int phrError);

		
		void Write([In] uint cProperties, [In] ref PROPBAG2 pPropBag, [In] [MarshalAs(UnmanagedType.Struct)] ref object pvarValue);

		
		int CountProperties();

		
        uint GetPropertyInfo([In] uint iProperty, [In] uint cProperties, out PROPBAG2 pPropBag);

		
		void LoadObject([In] [MarshalAs(UnmanagedType.LPWStr)] string pstrName, [In] uint dwHint, [In] [MarshalAs(UnmanagedType.IUnknown)] object pUnkObject, [In] [MarshalAs(UnmanagedType.Interface)] IErrorLog pErrLog);
	}
}
