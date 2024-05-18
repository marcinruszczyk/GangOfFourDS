using State;

var context = new Context(new ConcreteStateA());

context.Request();
context.Request();
context.Request();
context.Request();


Console.ReadKey();