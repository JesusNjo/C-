


//Interface

interface ISale
{
    double Total { get; }
 /* En JAVA:

 public interface ISale {
    double getTotal();
}

 */
}

interface ISave
{
    public void Save();
}

public class Sail : ISale, ISave
{
    public double Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Save()
    {
        Console.WriteLine("Guardado en base de datos");
    }
}

public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine($"{nameof(Beer)}");
    }
}
