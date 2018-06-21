using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
	public interface IWICBitmapLock
	{
		
		void GetSize(out uint puiWidth, out uint puiHeight);

		
        uint GetStride();

		
		void GetDataPointer(out uint pcbBufferSize, out IntPtr ppbData);

		
        Guid GetPixelFormat();
	}
}
