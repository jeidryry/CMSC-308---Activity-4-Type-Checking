using System;

class Program
{
    static void MakeAnimalSpeak(IAnimal animal)
    {
        animal.Speak();
    }

    static void Main()
    {
        int num = 10;
        //num = "Hello"; //error; can't convert string to int and vice versa
        Console.WriteLine(num);

        int x = 5;
        string y = "10";
        //int z = x + y // Error; it can't add int and string
        int z = x + int.Parse(y);// we must convert manually
        Console.WriteLine(z);

        Dog d = new Dog();
        Cat c = new Cat();

        MakeAnimalSpeak(d); // This Works
        // MakeAnimalSpeak(c); //  Error: Cat does not implement IAnimal

    }
}
interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak() => Console.WriteLine("Woof!");
}

class Cat
{
    public void Speak() => Console.WriteLine("Meow!");
}



