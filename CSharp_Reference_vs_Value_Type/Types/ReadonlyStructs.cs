namespace ProcessStructureAndClasses.Types;

public readonly struct Readonly_Struct_POCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public readonly long WorkPhoneNumber = workPhoneNumber;
    public readonly long HomePhoneNumber = homePhoneNumber;
    public readonly long Region = region;
}

public readonly struct Readonly_Struct_NPOCO(long homePhoneNumber, long workPhoneNumber, long region) : IReadonly_Struct_NPOCO
{
    public long WorkPhoneNumber { get; } = workPhoneNumber;
    public long HomePhoneNumber { get; } = homePhoneNumber;
    public long Region { get; } = region;
}