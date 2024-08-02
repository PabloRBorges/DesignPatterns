namespace Decorator.Repository
{
    public interface ICarStore
    {
        CarDto GetCarById(int id);
        CarDto GetCars();
    }
}
