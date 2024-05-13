using Adapter1;

Adaptee adaptee = new Adaptee();

ITarget adapter = new Adapter(adaptee);

Client client = new Client();
client.MakeRequest(adapter);