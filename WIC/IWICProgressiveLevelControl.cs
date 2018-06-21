using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
	public interface IWICProgressiveLevelControl
	{
		
		uint GetLevelCount();

		
		uint GetCurrentLevel();

		
		void SetCurrentLevel([In] uint nLevel);
	}
}
