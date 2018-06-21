using System;
using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct PROPBAG2
	{
		public uint dwType;

		public ushort vt;

		public ushort cfType;

		public uint dwHint;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pstrName;

		public Guid clsid;
	}
}
