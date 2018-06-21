using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICDdsEncoder
	{
		
		void SetParameters([In] ref WICDdsParameters pParameters);

		
        WICDdsParameters GetParameters();

		
		void CreateNewFrame([MarshalAs(UnmanagedType.Interface)] out IWICBitmapFrameEncode ppIFrameEncode, out uint pArrayIndex, out uint pMipLevel, out uint pSliceIndex);
	}
}
