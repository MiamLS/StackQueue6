// See https://aka.ms/new-console-template for more information
using StackQueue6;

Console.WriteLine("Hello, World!");

MyStackLinkedList<Person> persons = new MyStackLinkedList<Person>();

Person p1 = new Person(1, "bob", 20);
Person p2 = new Person(2, "Kevin", 20);
Person p3 = new Person(3, "Josh", 20);
Person p4 = new Person(4, "Bente", 20);

persons.Push(p1);
persons.Push(p2);
persons.Push(p3);

//Test af Peek og Pop
Console.WriteLine(persons.Peek());
//persons.Pop();
//Console.WriteLine(persons.Peek());

try
{
    persons.Push(p4);
}
catch (MyStackIsFullException mexp)
{
    Console.WriteLine(mexp.Message);
}