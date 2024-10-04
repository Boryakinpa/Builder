using Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        ConcreteComputer concreteComputer = new ConcreteComputer();
        Master master = new Master();
        Computer computer = master.Build(concreteComputer);
        Console.WriteLine(computer.ToString());
    }
}