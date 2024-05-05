using AdapterPattern;

Adaptee adaptee = new Adaptee();

ITarget adapter = new Adapter(adaptee);


Client client = new Client();
client.ExecuteRequest(adapter);


