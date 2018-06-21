using System.Runtime.InteropServices;

namespace WIC
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct WICJpegFrameHeader
	{
		public uint Width;

		public uint Height;

		public WICJpegTransferMatrix TransferMatrix;

		public WICJpegScanType ScanType;

		public uint cComponents;

		public uint ComponentIdentifiers;

		public uint SampleFactors;

		public uint QuantizationTableIndices;
	}
}
