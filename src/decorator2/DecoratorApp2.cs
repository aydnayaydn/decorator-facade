static class DecoratorApp2
{
    public static void Run(){
        Console.WriteLine("-----Decorator2 Pattern-----");
        var type1 = new PizzaType[] {PizzaType.Cheese };
        var type2 = new PizzaType[] {PizzaType.Pepper} ;
        var type3 = new PizzaType[] {PizzaType.Cheese, PizzaType.Onion} ;
        var type4 = new PizzaType[] {PizzaType.Cheese, PizzaType.Onion, PizzaType.Pepper} ;

        Pizza pizza = new Pizza();
        // Console.WriteLine(pizza.GetPizzaType());

        // var cheesePizza = new CheesePizzaDecorator(pizza);
        // Console.WriteLine(cheesePizza.GetPizzaType());

        // var pepperPizza = new PepperPizzaDecorator(pizza);
        // Console.WriteLine(pepperPizza.GetPizzaType());

        ShowReport(pizza, type1);
        ShowReport(pizza, type2);
        ShowReport(pizza, type3);
        ShowReport(pizza, type4);
    }
    static void ShowReport(Pizza report, PizzaType[] type)
    {
        PizzaDecorator decorator = new PizzaDecorator(report);

        if (type.Contains(PizzaType.Cheese))
            decorator = new CheesePizzaDecorator(decorator);
        if (type.Contains(PizzaType.Pepper))
            decorator = new PepperPizzaDecorator(decorator);
        if (type.Contains(PizzaType.Onion))
            decorator = new OnionPizzaDecorator(decorator);

        Console.WriteLine(decorator.GetPizzaType() + "\n");
    }
}