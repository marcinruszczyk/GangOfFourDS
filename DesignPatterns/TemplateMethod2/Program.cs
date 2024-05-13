using TemplateMethod2;

AbstractClass aA = new ConcreteClassA();
aA.TemplateMethod();


AbstractClass aB = new ConcreteClassB();
aB.TemplateMethod();

Console.ReadKey();