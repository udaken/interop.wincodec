using System;
using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[ComConversionLoss]
	public struct WICImageParameters
	{
		[ComConversionLoss]
		public IntPtr pixelFormat;

		public float dpiX;

		public float dpiY;

		public float Top;

		public float Left;

		public uint PixelWidth;

		public uint PixelHeight;
	}
}
