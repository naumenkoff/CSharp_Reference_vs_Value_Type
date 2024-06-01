namespace ProcessStructureAndClasses.Types;

public ref struct Ref_Struct_POCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public readonly long WorkPhoneNumber = workPhoneNumber;
    public readonly long HomePhoneNumber = homePhoneNumber;
    public readonly long Region = region;
}

public ref struct Ref_Struct_NPOCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public long WorkPhoneNumber { get; } = workPhoneNumber;
    public long HomePhoneNumber { get; } = homePhoneNumber;
    public long Region { get; } = region;
}