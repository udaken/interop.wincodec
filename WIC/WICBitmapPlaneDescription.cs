using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct WICBitmapPlaneDescription
	{
		[ComAliasName("WIC.WICPixelFormatGUID")]
        public System.Guid Format;

		public uint Width;

		public uint Height;
	}
}
