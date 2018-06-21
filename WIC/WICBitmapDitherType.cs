namespace WIC
{
	public enum WICBitmapDitherType : uint
	{
		None,
		Solid = 0,
		Ordered4x4,
		Ordered8x8,
		Ordered16x16,
		Spiral4x4,
		Spiral8x8,
		DualSpiral4x4,
		DualSpiral8x8,
		ErrorDiffusion,
	}
}
