using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[Guid("0000000B-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IStorage
	{
		
        [return: MarshalAs(UnmanagedType.Interface)]
        IStream CreateStream([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, [In] uint grfMode, [In] uint reserved1, [In] uint reserved2);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IStream RemoteOpenStream([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, [In] uint cbReserved1, [In] IntPtr reserved1, [In] uint grfMode, [In] uint reserved2);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IStorage CreateStorage([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, [In] uint grfMode, [In] uint reserved1, [In] uint reserved2);

		
        [return: MarshalAs(UnmanagedType.Interface)]
        IStorage OpenStorage([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, [In] [MarshalAs(UnmanagedType.Interface)] IStorage pstgPriority, [In] uint grfMode, [In] [ComAliasName("WIC.wireSNB")] IntPtr snbExclude, [In] uint reserved);

		
		void RemoteCopyTo([In] uint ciidExclude, [In] ref Guid rgiidExclude, [In] [ComAliasName("WIC.wireSNB")] IntPtr snbExclude, [In] [MarshalAs(UnmanagedType.Interface)] IStorage pstgDest);

		
		void MoveElementTo([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, [In] [MarshalAs(UnmanagedType.Interface)] IStorage pstgDest, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsNewName, [In] uint grfFlags);

		
		void Commit([In] uint grfCommitFlags);

		
		void Revert();

		
		void RemoteEnumElements([In] uint reserved1, [In] uint cbReserved2, [In] ref byte reserved2, [In] uint reserved3, [MarshalAs(UnmanagedType.Interface)] out IEnumSTATSTG ppenum);

		
		void DestroyElement([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName);

		
		void RenameElement([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsOldName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsNewName);

		
		void SetElementTimes([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, [In] ref System.Runtime.InteropServices.ComTypes.FILETIME pctime, [In] ref System.Runtime.InteropServices.ComTypes.FILETIME patime, [In] ref System.Runtime.InteropServices.ComTypes.FILETIME pmtime);

		
		void SetClass([In] ref Guid clsid);

		
		void SetStateBits([In] uint grfStateBits, [In] uint grfMask);

		
		void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, [In] uint grfStatFlag);
	}
}
