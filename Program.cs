// Factory Method Design Pattern - Creational Category //


using FactoryMethodPattern;

PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();
PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();

IPizza cheesePizza = ankaraPizzaStore.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in Ankara Store");

IPizza veggiePizza = istanbulPizzaStore.OrderPizza("veggie");
Console.WriteLine("Veggie pizza ordered in Istanbul Store");
