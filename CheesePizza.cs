
namespace FactoryMethodPattern;

class CheesePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Cheese Pizza Prepared");
    }

    public void Bake()
    {
        Console.WriteLine("Cheese Pizza Baked");
    }

    public void Cut()
    {
        Console.WriteLine("Cheese Pizza Cut");
    }
}
