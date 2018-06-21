using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct DXGI_JPEG_AC_HUFFMAN_TABLE
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] CodeCounts;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 162)]
		public byte[] CodeValues;
	}
}
