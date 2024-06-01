namespace ProcessStructureAndClasses.Types;

public struct Struct_POCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public readonly long WorkPhoneNumber = workPhoneNumber;
    public readonly long HomePhoneNumber = homePhoneNumber;
    public readonly long Region = region;
}

public struct Struct_NPOCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public long WorkPhoneNumber { get; } = workPhoneNumber;
    public long HomePhoneNumber { get; } = homePhoneNumber;
    public long Region { get; } = region;
}