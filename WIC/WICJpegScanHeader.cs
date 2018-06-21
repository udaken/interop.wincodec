using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct WICJpegScanHeader
	{
		public uint cComponents;

		public uint RestartInterval;

		public uint ComponentSelectors;

		public uint HuffmanTableIndices;

		public byte StartSpectralSelection;

		public byte EndSpectralSelection;

		public byte SuccessiveApproximationHigh;

		public byte SuccessiveApproximationLow;
	}
}
