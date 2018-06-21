using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("DC2BB46D-3F07-481E-8625-220C4AEDBB33")]
	public interface IWICEnumMetadataItem
	{
		
		void Next([In] uint celt, [In] [Out] ref PROPVARIANT rgeltSchema, [In] [Out] ref PROPVARIANT rgeltId, [In] [Out] ref PROPVARIANT rgeltValue , out uint pceltFetched);

		
		void Skip([In] uint celt);

		
		void Reset();

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IWICEnumMetadataItem Clone();
	}
}
