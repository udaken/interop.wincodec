using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WIC
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("135FF860-22B7-4DDF-B0F6-218F4F299A43")]
	public interface IWICStream : IStream
    {
        #region IStream
        new void Read(byte[] pv, int cb, IntPtr pcbRead);
        new void Write(byte[] pv, int cb, IntPtr pcbWritten);
        new void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);
        new void SetSize(long libNewSize);
        new void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);
        new void Commit(int grfCommitFlags);
        new void Revert();
        new void LockRegion(long libOffset, long cb, int dwLockType);
        new void UnlockRegion(long libOffset, long cb, int dwLockType);
        new void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag);
        new void Clone(out IStream ppstm);
        #endregion

        void InitializeFromIStream([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream);

		
		void InitializeFromFilename([In] [MarshalAs(UnmanagedType.LPWStr)] string wzFilename, [In] uint dwDesiredAccess);

		
		void InitializeFromMemory([In] IntPtr pbBuffer, [In] uint cbBufferSize);

		
		void InitializeFromIStreamRegion([In] [MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] UInt64 ulOffset, [In] UInt64 ulMaxSize);
	}
}
