using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3127CA40-446E-11CE-8135-00AA004BB851")]
	public interface IErrorLog
	{
		
		void AddError([In] [MarshalAs(UnmanagedType.LPWStr)] string pszPropName, [In] ref System.Runtime.InteropServices.ComTypes.EXCEPINFO pExcepInfo);
	}
}
