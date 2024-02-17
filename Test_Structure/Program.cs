class Prueba_Structure
{
    public static void Main(string[] args)
    {
        Empleado Empleado1 = new Empleado();
        Empleado Empleado2 = new Empleado();

        Empleado1.Name = "Alberto Perez";
        Empleado1.Age = 50;
        Empleado1.Address = "Paraguay 1355, CABA";


        Empleado2.Name = "Roberto Gimenez";
        Empleado2.Age = 45;
        Empleado2.Address = "Corrientes 344, CABA";

        Empleado1.Display();
        Empleado2.Display();

        Empleado1.Describe();

        Console.ReadKey();
    }
}

public interface Thing
{
    public void Describe();
}
public interface Persona
{
    public void Display();
 
}

public struct Empleado : Persona , Thing
{
    public string Name; public int Age; public string Address;
    public void Display()
    {
        Console.WriteLine("Name {0}", Name);
        Console.WriteLine("Age {0}", Age);
        Console.WriteLine("Address {0}", Address);
    }
    public void Describe()
    {
        Console.WriteLine("I am an Employee");
    }
}

//struct Books
//{
//    private string title;
//    private string author;
//    private string subject;
//    private int book_id;

//    public void getValues(string t, string a, string s, int id)
//    {
//        title = t;
//        author = a;
//        subject = s;
//        book_id = id;
//    }

//    public void display()
//    {
//        Console.WriteLine("Title : {0}", title);
//        Console.WriteLine("Author : {0}", author);
//        Console.WriteLine("Subject : {0}", subject);
//        Console.WriteLine("Book_id :{0}", book_id);
//    }
//};

//public class testStructure
//{

//    public static void Main(string[] args)
//    {
//        Books Book1 = new Books();   /* Declare Book1 of type Book */
//        Books Book2 = new Books();   /* Declare Book2 of type Book */

//        /* book 1 specification */
//        //Book1.getValues("C Programming",
//        //"Nuha Ali", "C Programming Tutorial", 6495407);
//        Book1.title = "Title";
//        Book1.author = "Pepe";
//        Book1.subject = "Subject";
//        Book1.book_id = 1;

//        /* book 2 specification */
//        Book2.getValues("Telecom Billing",
//        "Zara Ali", "Telecom Billing Tutorial", 6495700);

//        /* print Book1 info */
//        Book1.display();

//        /* print Book2 info */
//        Book2.display();

//        Console.ReadKey();
//    }
//}
