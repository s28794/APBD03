namespace apbdlab03;

public class LiquidContainer : ContainerBase, IHazardNotifier
{
    protected bool Hazardous { get; set; }

    public LiquidContainer(double weight, double height, double cargoWeight, double maxWeight, double depth,
        string containerType, bool hazardous) : base(weight, height, cargoWeight, maxWeight, depth, containerType)
    {
        Hazardous = hazardous;
    }

    public override void LoadTheContainer(int load)
    {
        if (load + Weight > MaxWeight * 0.5 & Hazardous)
        {
            DangerousSituationAlert(SerialNumber,"50%");
            throw new InvalidOperationException();
        } else if (load + Weight > MaxWeight * 0.9 & !Hazardous)
        {
            DangerousSituationAlert(SerialNumber,"90%");
            throw new InvalidOperationException();
            
        }
    }
    public void DangerousSituationAlert(string serialNumber, string percentage)
    {
        
        if (Hazardous)
        {
            Console.WriteLine(
                "Dangerous situation currently in Container no.: " + serialNumber + ", " 
                + "More than " + percentage + " of max weight exceeded while carrying hazardous materials!!!"
            );
        }
        else
        {
            Console.WriteLine(
                "Dangerous situation currently in Container no.: " + serialNumber + ", " 
                + "More than " + percentage + " of max weight exceeded!!!"
            );
        }
    }
}