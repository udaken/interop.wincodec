using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICJpegFrameDecode
	{
		
		void DoesSupportIndexing(out int pfIndexingSupported);

		
		void SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize);

		
		void ClearIndexing();

		
		void GetAcHuffmanTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);

		
		void GetDcHuffmanTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);

		
		void GetQuantizationTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);

		
		void GetFrameHeader(out WICJpegFrameHeader pFrameHeader);

		
		void GetScanHeader(uint scanIndex, out WICJpegScanHeader pScanHeader);

		
		void CopyScan(uint scanIndex, uint scanOffset, [In] uint cbScanData, IntPtr pbScanData, out uint pcbScanDataActual);

		
		void CopyMinimalStream(uint streamOffset, [In] uint cbStreamData, IntPtr pbStreamData, out uint pcbStreamDataActual);
	}
}
