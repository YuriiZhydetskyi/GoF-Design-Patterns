using Composite;

Console.WriteLine("Hello, World!");

var mainNode = new Node(0);
var node1 = new Node(11);
node1.Add(new Leaf(111));
node1.Add(new Leaf(222));
mainNode.Add(node1);
mainNode.Add(new Leaf(4));
mainNode.Add(new Leaf(5));

mainNode.Print("");
Console.WriteLine("Incrementing...");
mainNode.Increment();
mainNode.Print("");
Console.WriteLine("Decrementing...");
mainNode.Decrement();
mainNode.Print("");

Console.ReadLine();
