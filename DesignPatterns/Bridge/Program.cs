using Bridge;

IImplementator implementorA = new ConcreteImplementatorA();
Abstraction abstractionA = new RefinedAbstraction(implementorA);
abstractionA.Operation();


IImplementator implementorB = new ConcreteImplementatorB();
Abstraction abstractionB = new RefinedAbstraction(implementorB);
abstractionB.Operation();
