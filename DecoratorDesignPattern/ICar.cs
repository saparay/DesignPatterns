namespace DecoratorDesignPattern
{
    // This is the Base Component that defines operations that can be altered by decorators.
    public interface ICar
    {
        ICar ManufactureCar();
    }
}