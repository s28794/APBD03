namespace apbdlab03;

public class OverFillException : Exception
{
    public OverFillException()
    {
        Console.WriteLine("Not enough space in a Container to fill with the load");
    }
}