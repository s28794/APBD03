namespace apbdlab03;

public class GasContainer : ContainerBase, IHazardNotifier
{
    public GasContainer(double weight, double height, double cargoWeight, double maxWeight, double depth, string containerType) : base(weight, height, cargoWeight, maxWeight, depth, containerType)
    {
    }
    
    public override void EmptyTheContainer()
    {
        CargoWeight = CargoWeight * 0.05;

    }

    public override void LoadTheContainer(int load)
    {
        if (load + CargoWeight > MaxWeight)
        {
            DangerousSituationAlert(SerialNumber,"");
        }
    }

    public void DangerousSituationAlert(string serialNumber, string percentage)
    {
        throw new NotImplementedException();
    }
}