namespace DesignPatterns.Creational.Builder.CarBuilder
{
    public interface ICarBuilder
    {
        void Reset();
        void SetSeats();
        void SetEngine();
        void SetGps(bool v);

    }
}
