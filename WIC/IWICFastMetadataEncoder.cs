using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B84E2C09-78C9-4AC4-8BD3-524AE1663A2F")]
	public interface IWICFastMetadataEncoder
	{
		
		void Commit();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICMetadataQueryWriter GetMetadataQueryWriter();
	}
}
