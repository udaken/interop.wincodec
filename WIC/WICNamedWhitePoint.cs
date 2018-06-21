namespace WIC
{
    [System.Flags]
	public enum WICNamedWhitePoint
	{
		Default = 1,
		Daylight,
		Cloudy = 4,
		Shade = 8,
		Tungsten = 0x10,
		Fluorescent = 0x20,
		Flash = 0x40,
		Underwater = 0x80,
		Custom = 0x100,
		AutoWhiteBalance = 0x200,
		AsShot = 1,
	}
}
