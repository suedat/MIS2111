using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Week_3;

internal class Program
{
    static void Main(string[] args)
    {
        #region static_class_const
        Console.WriteLine(Sample.PI);
        //Sample obj = new Sample();

        Sample.Report();
        Console.WriteLine();
        #endregion

        #region x
        Student student1 = new Student();
        Student student2 = new Student("Sueda", 123);

        student1.Report();
        student2.Report();
        string myString = "Marmara University";

        Student student3 = null;

        int x = 42;
        //Nullable Type
        //int y = null; <- stackte saklanan değerler için null atanamaz. NULLABLE TYPE = int? y = null;
        int? y = null;
        float? z = null;
        bool? a = null;

        y = 101;
        y = null;
        if (student3 != null)
        {
            student3.Report();
        }
        /*else
        {
            Console.WriteLine($"{nameof(student3)} is null");
        }*/
        //student3?.Report(); // null conditional operation - ?
        student2?.Report();
        if (student3 is not null)
        {
            student3.Report();
        }
        Console.WriteLine($"student3 is null: {student3 is null}");
        Console.WriteLine($"student3 is not null: {student3 is not null}");

        int? newNullableValue = null;
        if (newNullableValue.HasValue)
        {
            Console.WriteLine($"newNullableValue has a value and it's {newNullableValue}");
        }
        else
        {
            Console.WriteLine("newNullableValue does not have a value");
        }

        newNullableValue = 15;

        if (newNullableValue.HasValue)
        {
            Console.WriteLine($"newNullableValue has a value and it's {newNullableValue}");
        }
        else
        {
            Console.WriteLine("newNullableValue does not have a value");
        }

        if (newNullableValue is not null) { }
        if (newNullableValue != null) { }

        int? x = 42;
        int  y = 101;
        int? z = y;

        Console.ReadLine();

        if(y.HasValue)
        {
            Console.WriteLine();
        }

        #endregion

        //REF AND OUT
        /*int y = 101;
        Console.WriteLine($"Value of y is: {y}");
        MethodThatUsesRef(ref y);
        Console.WriteLine($"Value of y is: {y}");

        int z;
        MethodThatUsesOut(out z);
        Console.WriteLine($"Value of y is: {z}");*/

        //Null Coalescing Operators
        Student student1 = new Student();
        Student student2 = null;
        Student student3;

        if (student2 is not null)
        {
            student3 = student2;
        }

        else
        {
            student3 = student1;
        }

        student3 = student2 ?? student1;
        Console.WriteLine("Student1: \n");
        student1.Report();
        Console.WriteLine("Student3: \n");
        student3.Report();
        Console.WriteLine("-------");
        student1.Name = "ABCDEFG";
        Console.WriteLine("Student1: \n");
        student1.Report();
        Console.WriteLine("Student3: \n");
        student3.Report();

        Console.ReadLine();


    }
    public static void MethodThatUsesRef(ref int x)
    {
        x += 1;
    }

    public static void MethodThatUsesOut(out int x)
    {
        x = 42;
    }


    //NULL COLESCING OPERATORS ??

}

// eğer bir değişken türünü null haline getirebilir yapılırsa null atanabilir. normal türün genişletlmiş hali.
// null check = student3 != null OR student3 is null
// null is not reffering an object in heap memory
//null -> millon dollar mistake
//Stack(value type)   Heap(refernace type)
//syntactic sugar


/*Ref Parameter(MethodThatUsesRef):
The ref keyword indicates that the parameter is being passed by reference
Any changes made to the parameter within the method will affect the original variable.

Out Parameter (MethodThatUsesOut):
The out keyword is similar to ref but is designed for cases where the parameter might not
be initialized before being passed to the method. The method must assign a value to the out parameter before it returns.*/