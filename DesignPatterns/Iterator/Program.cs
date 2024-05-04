using Iterator;

var aggregate = new ConcreteAggregate();

aggregate.Add("Item 1");
aggregate.Add("Item 2");
aggregate.Add("Item 3");


var iterator = aggregate.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}