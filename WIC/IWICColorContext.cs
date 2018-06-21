using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICColorContext
	{
		
		void InitializeFromFilename([In] [MarshalAs(UnmanagedType.LPWStr)] string wzFilename);

		
		void InitializeFromMemory([In] IntPtr pbBuffer, [In] uint cbBufferSize);

		
		void InitializeFromExifColorSpace([In] uint value);


        WICColorContextType GetType();

		
		void GetProfileBytes([In] uint cbBuffer, [Out] byte[] pbBuffer, out uint pcbActual);


        uint GetExifColorSpace();
	}
}
