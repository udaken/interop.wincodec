namespace WIC
{
    [System.Flags]
	public enum WICBitmapDecoderCapabilities : uint
    {
		SameEncoder = 1,
		CanDecodeAllImages,
		CanDecodeSomeImages = 4,
		CanEnumerateMetadata = 8,
		CanDecodeThumbnail = 0x10,
	}
}
