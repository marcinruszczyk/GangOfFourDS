using Mediator;

var mediator = new ConcreteMediator();

var colleague1 = new ConcreteColleague1(mediator);
var colleague2 = new ConcreteColleague2(mediator);


mediator.AddColleague(colleague1);
mediator.AddColleague(colleague2);

colleague1.Send("Hello from colleague 1");
colleague2.Send("Hello from colleague 2");
