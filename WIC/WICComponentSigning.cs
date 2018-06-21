namespace WIC
{
    [System.Flags]
	public enum WICComponentSigning
	{
		Signed = 1,
		Unsigned,
		Safe = 4,
		Disabled = -2147483648,
	}
}
