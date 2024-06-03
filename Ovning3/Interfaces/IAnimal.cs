namespace Ovning3.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        double Weight { get; set; }

        void DoSound();
        string Stats();
    }
}