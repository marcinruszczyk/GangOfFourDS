using Observer;

var subject = new ConcreteSubject();

var observer1 = new ConcreteObserver(subject);
var observer2 = new ConcreteObserver(subject);


subject.State = 10;


subject.Detach(observer1);

subject.State = 20;
