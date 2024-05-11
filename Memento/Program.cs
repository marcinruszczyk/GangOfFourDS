using Memento;

//create originator

var originator = new Originator();


//Create caretaker
var caretaker = new Caretaker();

//Set originator state and save to memento 


originator.State = "State1";
caretaker.Memento = originator.SaveStateToMemento();

//change originator state

originator.State = "State2";

//Restore state from memento

originator.GetStateFromMemento(caretaker.Memento);



