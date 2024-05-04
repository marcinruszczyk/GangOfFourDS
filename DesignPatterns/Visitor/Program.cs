using Visitor;

var objectStructure = new ObjectStructure();

objectStructure.Attach(new ConcreteElementA());
objectStructure.Attach(new ConcreteElementB());

var visitor = new ConcreteVisitor();

objectStructure.Accept(visitor);