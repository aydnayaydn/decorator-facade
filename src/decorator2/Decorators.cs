//Base Decorator
class PizzaDecorator : IPizza
{
    private IPizza _pizza;
    public PizzaDecorator(IPizza pizza) => _pizza = pizza;
    public virtual string GetPizzaType() => _pizza.GetPizzaType();
}

enum PizzaType{
    Cheese,
    Pepper,
    Onion,
}

//Concrete Decorators
class CheesePizzaDecorator : PizzaDecorator
{
    public CheesePizzaDecorator(IPizza pizza) : base(pizza) {}
    public override string GetPizzaType() => base.GetPizzaType() + "\r\n with extra cheese"; 
}

class PepperPizzaDecorator : PizzaDecorator
{
    public PepperPizzaDecorator(IPizza pizza) : base(pizza) {}
    public override string GetPizzaType() => base.GetPizzaType() + "\r\n with extra pepper"; 
}

class OnionPizzaDecorator : PizzaDecorator
{
    public OnionPizzaDecorator(IPizza pizza) : base(pizza) {}
    public override string GetPizzaType() => base.GetPizzaType() + "\r\n with extra onion"; 
}