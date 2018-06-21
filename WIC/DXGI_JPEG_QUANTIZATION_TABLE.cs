using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct DXGI_JPEG_QUANTIZATION_TABLE
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] Elements;
	}
}
