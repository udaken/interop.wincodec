using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
	public interface IWICDdsFrameDecode
	{
		
		void GetSizeInBlocks(out uint pWidthInBlocks, out uint pHeightInBlocks);


        WICDdsFormatInfo GetFormatInfo();

		
		void CopyBlocks([In] ref WICRect prcBoundsInBlocks, [In] uint cbStride, [In] uint cbBufferSize, [Out] byte[] pbBuffer);
	}
}
