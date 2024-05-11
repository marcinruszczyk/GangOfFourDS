using Memento;

Orginator o = new Orginator();
o.State = "On";

//Store internal state 

Caretaker c = new Caretaker();
c.Memento = o.CreateMemento();

o.State = "off";

//restored saved state

o.SetMemento(c.Memento);

//wait for user

Console.ReadKey();