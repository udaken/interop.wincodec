namespace WIC
{
    [System.Flags]
	public enum WICProgressNotification
	{
		Begin = 0x10000,
		End = 0x20000,
		Frequent = 0x40000,
		All = -65536,
	}
}
