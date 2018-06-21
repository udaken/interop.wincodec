namespace WIC
{
    [System.Flags]
	public enum WICBitmapTransformOptions : uint
	{
		Rotate0,
		Rotate90,
		Rotate180,
		Rotate270,
		FlipHorizontal = 8,
		FlipVertical = 0x10,
	}
}
