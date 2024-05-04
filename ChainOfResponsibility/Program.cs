using ChainOfResponsibility;

var handler1 = new ConcreteHandler();
var handler2 = new ConcreteHandler();
var handler3 = new ConcreteHandler();


handler1.SetNext(handler2);
handler2.SetNext(handler3);

//send request to the chain

handler1.HandleRequest(5);
handler1.HandleRequest(12);
handler1.HandleRequest(8);


