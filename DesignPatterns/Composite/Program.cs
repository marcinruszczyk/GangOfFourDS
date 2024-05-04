
using Compositer;



var leaf1 = new Leaf("1");
var leaf2 = new Leaf("2");
var leaf3 = new Leaf("3");

var composite = new Composite();

composite.Add(leaf1);
composite.Add(leaf2);

var composite2 = new Composite();

composite2.Add(leaf3);
composite2.Add(composite);

composite2.Operation();





