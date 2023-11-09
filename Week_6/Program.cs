namespace Week_6;
using Week_6.School;

class Program
{
    static void Main(string[] args)
    {
        #region Inheritance-Polymorphism
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        Bird myBird = new Bird();
        myDog.Eat();
        myDog.Breathe();
        myDog.Run();

        myBird.Eat();
        Animal myAnimal2 = myDog;
        myDog.Eat();
        myAnimal2.Eat();
        myBird.Eat();

        // Dog myDog2 = myAnimal; Child class object cannot refer parent class
        Console.ReadLine();

        #endregion


        Student std1 = new Student("abcd", 123, 3.14f);
        std1.Report();

    }
}
// Polymorphism    -Parent class ref Can refer child class object


/*Inheritance
//base keyword
hiding cbase class method and new keyword
virtual- override - base keyword again
protected keyword
extension methodw
interfaces
abstract classes
abstract method
sealed clasess
sealed methods


*/