namespace WIC
{
    [System.Flags]
	public enum WICComponentEnumerateOptions : int
	{
		Default,
		Refresh,
		Disabled = -2147483648,
		Unsigned = 0x40000000,
		BuiltInOnly = 0x20000000,
	}
}
