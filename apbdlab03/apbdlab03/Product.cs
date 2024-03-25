namespace apbdlab03;

public class Product
{
    protected string Name { get; }
    protected double Temperature { get; }

    public Product(string name, double temperature)
    {
        this.Name = name;
        this.Temperature = temperature;
    }

    public string getName()
    {
        return Name;
    }

    public double getTemperature()
    {
        return Temperature;
    }
    
}