namespace WIC
{
    [System.Flags]
	public enum WICComponentType
	{
		Decoder = 1,
		Encoder,
		PixelFormatConverter = 4,
		MetadataReader = 8,
		MetadataWriter = 0x10,
		PixelFormat = 0x20,
		AllComponents = 0x3F,
	}
}
