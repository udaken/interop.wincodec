using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[ComImport]
	[Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWICJpegFrameEncode
	{
		
        DXGI_JPEG_AC_HUFFMAN_TABLE GetAcHuffmanTable(uint scanIndex, uint tableIndex);

		
        DXGI_JPEG_DC_HUFFMAN_TABLE GetDcHuffmanTable(uint scanIndex, uint tableIndex);

		
        DXGI_JPEG_QUANTIZATION_TABLE GetQuantizationTable(uint scanIndex, uint tableIndex);

		
		void WriteScan([In] uint cbScanData, [In] IntPtr pbScanData);
	}
}
