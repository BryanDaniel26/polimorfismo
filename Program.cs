using System;

abstract class Animal
{
    protected int legs;

    //Constructor de la clase abstracta Anim
     protected Animal(int legs)
    {
        this.legs = legs;
    }

    protected Animal()
    {
        legs = legs;
    }

    //Metodos

    public void walk()
    {
        Console.WriteLine("Los animales caminan.");
    }
    public void eat()
    {
        Console.WriteLine("Los animales comen.");
    }
}

//**************************Interface pet************************

interface Pet
{
    string getName();
     void setName(string n);
     void play();
}


//**************************class cat************************

class Cat : Animal
{
    private string name;

    //Constructores
    public Cat(string n)
    {
        this.name = n;
    }
    public Cat() 
    { 
        name = name;
    }

    //Metodos

    public void setName(string n)
    {
        this.name = n;
    }
    public string getName()
    {
        return name;
    }

    public void play()
    {
        Console.WriteLine("Los gatos juegan.");
    }

    public virtual void eat() {Console.WriteLine("Los gatos comen."); }

}

//**************************class Fish************************

class Fish : Pet
{
    private string name;

    //Constructor
    public Fish()
    {
        this.name = name;
    }

    //Metodos
    public string getName() { return name;}
    public void setName(string n)
    {
        this.name = n;
     }
    public void play() { Console.WriteLine("El pez juega."); }
    public void walk() { Console.WriteLine("El pez no camina."); }
    public void eat() { Console.WriteLine("El pez come.");}

}

//**************************class Spider************************
class Spider : Fish, Pet
{
    public Spider() { }

    public virtual void eat() { Console.WriteLine("Las arañas comen.");}
}

//Testear

class Program
{
    static void Main()
    {
        //Clase Cat

        Cat unAnimal = new Cat();
        Console.WriteLine("\n\tNombre del gato: {0}", unAnimal.getName());
        unAnimal.eat();
        unAnimal.setName("Misu");
        unAnimal.getName();
        unAnimal.walk();
        unAnimal.play();

        //Class Fish
        Fish pez = new Fish();
        Console.WriteLine("\n\tNombre del Pez: {0}", pez.getName());
        pez.eat();
        pez.setName("Nemo");
        pez.getName();
        pez.walk();
        pez.play();

        //Clas Spider
        Spider spider = new Spider();
        spider.setName("Peter");
        Console.WriteLine("\n\tNombre de la araña {0}", spider.getName());
        spider.eat();
        
    }
}