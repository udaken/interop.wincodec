using System;
using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[ComConversionLoss]
	public struct WICBitmapPattern
	{
		public UInt64 Position;

		public uint Length;

		[ComConversionLoss]
		public IntPtr Pattern;

		[ComConversionLoss]
		public IntPtr Mask;

        [MarshalAs(UnmanagedType.Bool)]
		public bool EndOfStream;
	}
}
