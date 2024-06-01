namespace ProcessStructureAndClasses.Types;

public class Class_POCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public readonly long HomePhoneNumber = homePhoneNumber;
    public readonly long Region = region;
    public readonly long WorkPhoneNumber = workPhoneNumber;
}

public class Class_NPOCO(long homePhoneNumber, long workPhoneNumber, long region)
{
    public long WorkPhoneNumber { get; } = workPhoneNumber;
    public long HomePhoneNumber { get; } = homePhoneNumber;
    public long Region { get; } = region;
}