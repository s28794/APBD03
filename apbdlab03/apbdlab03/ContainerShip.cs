namespace apbdlab03;

public class ContainerShip
{
    protected List<ContainerBase> Containers;
    protected double MaxSpeed;
    protected int MaxContainers;
    protected double MaxWeight;

    public ContainerShip(List<ContainerBase> containers, double maxSpeed, int maxContainers, double maxWeight)
    {
        Containers = new List<ContainerBase>();
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        Containers.Capacity = MaxContainers;
    }

    public void AddContainerToShip(ContainerBase container)
    {
        Containers.Add(container);
    }

    public void RemoveContainerFromShip(ContainerBase container)
    {
        Containers.Remove(container);
    }
}