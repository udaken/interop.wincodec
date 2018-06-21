using System;
using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[ComConversionLoss]
	public struct WICBitmapPlane
	{
		[ComAliasName("WIC.WICPixelFormatGUID")]
        public System.Guid Format;

		[ComConversionLoss]
		public IntPtr pbBuffer;

		public uint cbStride;

		public uint cbBufferSize;
	}
}
