using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WIC
{
    public static class Constants
    {
        public const uint WIC_JPEG_MAX_COMPONENT_COUNT = (4);

        public const uint WIC_JPEG_MAX_TABLE_INDEX = (3);
    }
    public enum WIC_JPEG_QUANTIZATION_BASELINE
    {
        ONE = (0),

        THREE = (0x10100),
    }
    public enum WIC_JPEG_SAMPLE_FACTORS
    {
       ONE = (0x11),

       THREE_420 = (0x111122),

       THREE_422 = (0x111121),

       THREE_440 = (0x111112),

       THREE_444 = (0x111111),
    }
    public enum WIC_JPEG_HUFFMAN_BASELINE
    {
        ONE = (0),
        THREE = (0x111100),
    }

}
