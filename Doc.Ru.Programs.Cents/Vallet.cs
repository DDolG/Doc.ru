namespace Doc.Ru.Programs.Cents;

public class Vallet
{
    [NumberOfCents(1)]
    public uint Pennies { get; set; }
    
    [NumberOfCents(5)]
    public uint Nikels { get; set; }
    
    [NumberOfCents(10)]
    public uint Dimes { get; set; }
    
    [NumberOfCents(25)]
    public uint Quarters { get; set; }
}
