using CSharpCrash;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        /*PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        ComparisonOperators();
        LogicalOperators();
        ConditionalStatements();
        Loops();
        Arrays();
        Lists(); 
        Methods();
        Classes();*/
        ExceptionHandling();
    }

    static void PrintToConsole()
    {
        Console.WriteLine("Hello, World!");
    }

    static void VariablesAndDataTypes()
    {
        int age = 30;
        Console.WriteLine(age);
        float temperature = 20.4f;
        Console.WriteLine(temperature);
        double interest = 5.53;
        Console.WriteLine("Interest:" + interest);
        decimal stockPrice = 4.53535904M;
        Console.WriteLine("Stock price: " + stockPrice);
        char grade = 'A';
        Console.WriteLine(grade);
        string name = "Ronaldo";
        Console.WriteLine($"My name is {name}");
        bool isStudent = true;
        Console.WriteLine($"It's {isStudent} that Paul is student");
        int quantity;
        string product;
        quantity = 5;
        product = "bananas";
        Console.WriteLine($"Quantity: {quantity}. Product: {product}");
        const Double Pi = 3.14;
        Console.WriteLine(Pi);
    }

    static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;
        int addition = num1 + num2;
        Console.WriteLine(addition);
        int subtraction = num1 - num2;
        Console.WriteLine(subtraction);
        int multiplication = num1 * num2;
        Console.WriteLine(multiplication);
        int division = num1 / num2;
        Console.WriteLine(division);
        int modulus = num1 % num2;
        Console.WriteLine(modulus);
        int num3 = 5;
        int num4 = 0;

        try
        {
            int quotient = num3 / num4;
            Console.WriteLine(quotient);
        } catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error ocurred:" + ex.Message);
        }

        //Casting
        int num5 = 105;
        Double num5AsDouble = (Double)num5;
        Console.WriteLine(num5AsDouble);
    }

    static void ComparisonOperators()
    {
        int a = 10; int b = 5;

        bool isEqual = (a == b);
        bool isNotEqual = (a != b);
        bool isLessThan = (a < b);
        bool isGreaterThan = (a > b);
        bool isLessThanOrEqual = (a <= b);
        bool isGreaterThanOrEqual = (a >= b);
        Console.WriteLine(isGreaterThanOrEqual);
    }

    static void LogicalOperators()
    {
        bool x = true;
        bool y = false;

        bool andResult = x && y;
        Console.WriteLine(andResult);

        bool orResult = x || y;
        Console.WriteLine(orResult);

        bool notResult1 = x && !y;
        Console.WriteLine(notResult1);

        bool notResult2 = !x;
        Console.WriteLine(notResult2);
    }

    static void ConditionalStatements()
    {
        int age = 100;
        if (age < 18)
        {
            Console.WriteLine("You are a minor");
        } else if (age >= 18 & age < 65)
        {
            Console.WriteLine("You are an adult");
        } else
        {
            Console.WriteLine("You are a senior citizen");
        }

        int day = 6;
        string dayName = "Monday";
        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            default:
                dayName = "Weekend";
                break;
        }
        Console.WriteLine($"The day is {dayName}");
    }

    static void Loops()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number:" + i);
        }

        int count = 0;
        while (count < 5)
        {
            Console.WriteLine("count:" + count);
            count++;
        }

        count = 0;

        do
        { Console.WriteLine("do-while:" + count);
            count++;

        } while (count < 10);

        int[] numbers = {1,2,3,4,5,6,7,8,9,10};

        foreach (int i in numbers)
        {
            Console.WriteLine("i:" + i);
        }

        for(int i = 0;i < numbers.Length;i++)
        {
            Console.WriteLine("standard for loop:" + numbers[i]);
        }
    }

    static void Arrays()
    {
        string[] names = new string[3];
        names[0] = "Ron";
        names[1] = "Katie";
        names[2] = "Jack";

        Console.WriteLine(names.Length);
        Console.WriteLine(names[1]);
    }



    static void Lists()
    {
        //Lists can be dynamically updated.Allow duplicates
        List<string> cities = new List<string>();
        cities.Add("Paris");
        cities.Add("Berlin");
        cities.Add("Atenas");

        Console.WriteLine(cities.Count);
        Console.WriteLine(cities[cities.Count - 1]);

        foreach (string city in cities) Console.WriteLine("City:" + city);

        //Hashsets can be dynamically updated. Don't allow duplicates
        HashSet<string> countries = new HashSet<string>();

        countries.Add("France");
        countries.Add("Germany");
        countries.Add("Italy");

        Console.WriteLine(countries.Count);
        foreach (string country in countries) Console.WriteLine(country);

        //Dictionnary is a set of key,values. key is unique

        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        string dictKey1 = "Alice";
        int age1 = 30;
        ageDict.Add(dictKey1, age1);        //Other way to initialize: ageDict={"Alice": 30, "Bob": 50}

        if (ageDict.ContainsKey(dictKey1))
        {
            Console.WriteLine($"{dictKey1} has {ageDict[dictKey1]} years");
        }

        //Inicializacion
        Dictionary<string, int> ageDictInit = new Dictionary<string, int>()
            {
            { "Alice", 30},
            { "Bob", 50}
            };

        //foreach accede a cada key,value
        foreach (var entry in ageDict)
        {
            Console.WriteLine("Key:" + entry.Key);
            Console.WriteLine("Value:" + entry.Value);
        }

        //Queue Pila FIFO
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        while (queue.Count > 0)
        {
            string item;
            item = queue.Dequeue();
            Console.WriteLine("item is: " + item);
        }


        //Stack PILA LIFO (como una pila de papeles)

        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        
        while (stack.Count > 0)
        {
            string item;
            item = stack.Pop();
            Console.WriteLine("item is: " + item);
        }
    }

     static void Methods()
    {
        SayHello();
        int a = 10;
        int b = 5;
        int sum = Add(a, b);
        Console.WriteLine("Sum:" + sum);
       
    }
    //Solo accesible en esta clase
    private static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static void Classes()
    {
        Person p = new Person("John", 30);
        p.Greet();
    }

    private static void ExceptionHandling()
    {
        int a = 10;
        int b = 0;

        try
        {
            int result = a / b;
        } catch (DivideByZeroException ex) 
        { 
        Console.WriteLine(ex.Message);
        }

        List<string> shapes = new List<string>(){ "square", "rectangle", "circle" };

        try
        {
            Console.WriteLine(shapes[2]);
        } catch ( Exception ex)
        {
            Console.WriteLine("Index out of bounds. " + ex.Message);
        }   
        finally
        { Console.WriteLine("Program ended"); }

        bool isStudent = false;
        try
        {
            if (isStudent)
            {
                Console.WriteLine("This is a student");
            }
            else
            {
                throw new CustomException("You can not enroll if you are not a student.");
            }
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.Message);
        }
  
    }
}


