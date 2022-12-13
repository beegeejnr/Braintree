public sealed class Settings
{
    public int KeyOne { get; set; }
    public bool KeyTwo { get; set; }
    public string[]? IPAddressRange { get; set; }
    public NestedSettings KeyThree { get; set; } = null!;
}