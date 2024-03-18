
using apbdlab03;
public abstract class ContainerBase
{
    protected double Weight { get; set; }
    protected double Height { get; set; }
    protected double CargoWeight { get; set; }
    protected double MaxWeight { get; }
    protected double Depth { get; set; }
    protected string SerialNumber { get; }
    protected static int Id;

    protected ContainerBase(
        double weight, double height, double cargoWeight, double maxWeight, double depth, string containerType
        )
    {
        if (Id == 0)
        {
            Id = 1;
        }
        else
        {
            Id++;
        }
        Weight = weight;
        Height = height;
        CargoWeight = cargoWeight;
        MaxWeight = maxWeight;
        Depth = depth;
        SerialNumber = "KON" + "-" + containerType + "-" + Id;
    }

    public void EmptyTheContainer()
    {
        CargoWeight = 0;

    }

    public virtual void LoadTheContainer(int load)
    {
        double FreeWeight = MaxWeight - CargoWeight - Weight;
        if (load <= FreeWeight)
        {
            CargoWeight += load;
        }
        else
        {
            throw new OverFillException();
        }
    }
}