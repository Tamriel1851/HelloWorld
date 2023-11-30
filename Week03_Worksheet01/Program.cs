using System.IO;

namespace Week03_Worksheet01
{
// Taks 1.1
    //    internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int index = 0;
    //        void Method1()
    //        {                
    //            Console.WriteLine($"Method{index} called!");
    //        }
    //        void Method2()
    //        {
    //            index = index + 1;
    //            Console.WriteLine($"Method{index} called");
    //        }
    //    }
    //}
}



namespace Week03_Worksheet01
{
//Task 1.2
//        public class Rectangle
//{
//    float height;
//    float width;

//    public Rectangle(float width, float height)
//    {
//        this.width = width;
//        this.height = height;
//    }
//    public float CalculateArea()
//    {
//        return width * height;
//    }
//    public float Width
//    {
//        get { return width; }
//        set { width = value; }
//    }
//    public float Height
//    {
//        get { return height; }
//        set { width = value; }
//    }
//    static void Main(string[] args)
//    {
//        Rectangle myRectangle = new Rectangle(5.0f, 3.0f);
//        float area = myRectangle.CalculateArea();
//        Console.WriteLine("The area of the rectangle is: " + area);

//    }
//}
}

namespace Week03_Worksheet01
{
    // Task 1.3

    //class Person
    //{
    //    public string Name; 
    //    public int Age;

    //    public void SayHello()
    //    {
    //        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person[] people = new Person[3];

    //        for (int i = 0; i < 3; i++)
    //        {
    //            Console.Write("Enter name for person " + (i + 1) + ": ");
    //            string name = Console.ReadLine();

    //            Console.Write("Enter age for person " + (i + 1) + ": ");
    //            int age = int.Parse(Console.ReadLine());

    //            people[i] = new Person
    //            {
    //                Name = name,
    //                Age = age
    //            };
    //        }

    //        Console.WriteLine("Greetings from these people:");
    //        foreach (var person in people)
    //        {
    //            person.SayHello();
    //        }
    //    }
    //}

}

namespace Week03_Worksheet01
{
// Task 2
//    public class Point
//    {
//        private float x;
//        private float y;

//        public Point(float x, float y)
//        {
//            SetPosition(x, y);
//        }

//        public void SetPosition(float newX, float newY)
//        {
//            if (newX < 0)
//            {
//                x = 0;
//            }
//            else
//            {
//                x = newX;
//            }

//            if (newY < 0)
//            {
//                y = 0;
//            }
//            else
//            {
//                y = newY;
//            }
//        }

//        public float X
//        {
//            get { return x; }
//        }

//        public float Y
//        {
//            get { return y; }
//        }
//    }

//class Program
//    {
//        static void Main()
//        {
//             Instantiate a Point object
//            Point point = new Point(10.5f, 20.0f);

//             Display the initial position
//            Console.WriteLine($"Initial Position: X={point.X}, Y={point.Y}");

//             Set the position with negative values
//            point.SetPosition(-5.0f, -15.5f);

//             Display the updated position
//            Console.WriteLine($"Updated Position: X={point.X}, Y={point.Y}");

//             Set the position with non-negative values
//            point.SetPosition(30.0f, 25.0f);

//             Display the final position
//            Console.WriteLine($"Final Position: X={point.X}, Y={point.Y}");
//        }
//    }

}

namespace Week03_Worksheet01
{
//Task 3
//    public class Address
//    {
//        public string Street { get; set; }
//        public string City { get; set; }
//        public string PostCode { get; set; }

//        public Address(string street, string city, string postCode)
//        {
//            Street = street;
//            City = city;
//            PostCode = postCode;
//        }

//        public override string ToString()
//        {
//            return $"{Street}, {City}, {PostCode}";
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public Address Address { get; set; }

//        public Person(string name, int age, Address address)
//        {
//            Name = name;
//            Age = age;
//            Address = address;
//        }
//        public override string ToString()
//        {
//            return $"{Name}, Age: {Age}, Address: {Address}";
//        }
//        class Program
//        {
//            static void Main()
//            {
//                List<Person> list = new List<Person>();

//                while (true)
//                {
//                    Console.WriteLine("Enter person's details or type in 'quit' to stop: ");
//                    Console.WriteLine("Name: ");
//                    string name = Console.ReadLine();

//                    if (name.ToLower() == "quit")
//                        break;

//                    Console.WriteLine("Age: ");
//                    if (!int.TryParse(Console.ReadLine(),out int age))
//                    {
//                        Console.WriteLine("Invalid age input. Please try again");
//                        continue;
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            Address address1 = new Address("71-76 Wright Street", "Hull", "HU2 8JR");
//            Person person1 = new Person("Dawid Nowakowski", 31, address1);
//            Console.WriteLine(person1.ToString());

//            Address address2 = new Address("40 Derringham Street", "Hull", "HU3 1EW");
//            Person person2 = new Person("Mike Smith", 66, address2);
//            Console.WriteLine(person2.ToString());

//        }

//    }
}
