using System;

abstract class Animal
{
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Zzz...");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog says: Woof Woof");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat says: Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.MakeSound();
        myDog.Sleep();

        Cat myCat = new Cat();
        myCat.MakeSound();
        myCat.Sleep();
    }
}
