namespace apbdlab03;

public class RefrigratedContainer : ContainerBase
{
    protected readonly Product ProductType;
    protected double Temperature;
    
    public RefrigratedContainer(double weight, double height, double cargoWeight, double maxWeight, double depth, string containerType, double temperature, Product productType) : base(weight, height, cargoWeight, maxWeight, depth, containerType)
    {
        if (productType.getTemperature() > temperature)
        {
            Temperature = productType.getTemperature();
        }
        else
        {
            Temperature = temperature;
        }
    }
}