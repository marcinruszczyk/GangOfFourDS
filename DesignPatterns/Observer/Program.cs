using Observer;

ConcreteSubject s = new ConcreteSubject();

s.Attach(new ConcreteObserver(s, "X"));
s.Attach(new ConcreteObserver(s, "Y"));
s.Attach(new ConcreteObserver(s, "Z"));


s.SubjectState = "ABC";
s.Notify();

Console.ReadKey();
