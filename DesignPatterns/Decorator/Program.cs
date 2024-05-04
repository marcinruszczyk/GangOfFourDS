using Decorator;

var componnet = new ConcreteComponent();

var decoratorA = new ConcreteDecoratorA(componnet);
var decoratorB = new ConcreteDecoratorB(componnet);

decoratorB.Operation();