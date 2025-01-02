
using System;
using System.ComponentModel;
using System.Xml.Linq;



namespace Ass01OOP
{

    #region 1-  Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.


    //enum WeekDays 
    //{
    //    Sunday,
    //    Monday ,
    //    Tuesday ,
    //    Wednesday ,
    //    Thursday,
    //    Friday,
    //    Saturday
    //}

    #endregion


    #region 2 - Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

    //struct Person()
    //{
    //    public string Name { get; set; }
    //    private int age;


    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value < 1 ? 1 : value; }
    //    }




    //}

    #endregion

    #region 3 - Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    //enum Season
    //{
    //    Spring=0,
    //    spring=0,
    //    Summer=1,
    //    summer=1,
    //    Autumn=2, 
    //    autumn=2,
    //    Winter=3,
    //    winter=3

    //}

    #endregion

    #region 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

    //[Flags]
    //enum Permissions:byte
    //{
    //    Read=1,
    //    read=1,
    //    write=2,
    //    Write=2,
    //    Delete=4,
    //    delete=4,
    //    Execute=8,
    //    execute=8
    //}


    #endregion

    #region 5 - Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
    //enum Colors
    //{
    //    Red=0, 
    //    red=0, 
    //    Green=1, 
    //    green=1, 
    //    Blue=2,
    //    blue=2,
    //}

    #endregion


    #region 6- Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

    //public struct Point()
    //{



    //    public double X { get; set; }
    //    public double Y { get; set; }







    //}


    #endregion



    #region 7- Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

    //struct Person()
    //{
    //    public string Name;
    //    public int Age;

    //    public Person(string _name,int _age):this()
    //    {
    //        Name = _name;
    //        Age = _age;
            
    //    }
    //}

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-  Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.


            //Array days = Enum.GetValues(typeof(WeekDays));

            //foreach (WeekDays day in days)
            //{
            //    Console.WriteLine(day);

            //}
            #endregion



            #region 2 - Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[] 
            //{
            //    new Person() { Name = "Khaled", Age = 25 }, 
            //    new Person() { Name = "Saied", Age = 33 }, 
            //    new Person() { Name = "Salama", Age = 30 },
            //    new Person() { Name = "Mai", Age = 28 }
            //} ;

            //foreach (Person person in persons) { Console.WriteLine($"Name : {person.Name} , Age : {person.Age}"); }
            #endregion


            #region 3 - Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //bool flag = false;
            //Season season;
            //do
            //{
            //   flag =   Enum.TryParse<Season>(Console.ReadLine(), out  season);
            //}
            //while (flag==false);
            //Console.WriteLine(season);
            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Month range from March to May");
            //        break;
            //    case Season.summer:
            //        Console.WriteLine("Month range from June to August");
            //        break;
            //    case Season.autumn:
            //        Console.WriteLine("Month range from September to Novembe");
            //        break;
            //    case Season.winter:
            //        Console.WriteLine("Month range from December to February");
            //        break;
            //}
            #endregion




            #region 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            //Permissions permissions = (Permissions)10;

            //Permissions permission;

            //bool flag= false;


            //do
            //{
            //    Console.WriteLine("Enter Permission name to check");

            //   flag = Enum.TryParse<Permissions>(Console.ReadLine(), out permission);
            //}
            //while (flag==false);

            //if ((permissions & permission) == permission)
            //{
            //    Console.WriteLine($"Yes you've permission {permission}");
            //    Console.WriteLine($"As your Permissions is {permissions}");

            //}
            //else { Console.WriteLine($"You don't have this permission {permission}");
            //    Console.WriteLine($"As your Permissions is {permissions}");
            //}


            #endregion



            #region 5- Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.



            //Console.WriteLine("Enter Color name to check if its primary color or not");

            //bool flag = false;


            //flag = Enum.TryParse<Colors>(Console.ReadLine(), out Colors color);

            //if (flag==true)
            //{

            //    Console.WriteLine($"Color {color} is primary number");

            //}
            //else { Console.WriteLine($"Color {color} is not primary number"); }





            #endregion


            #region 6- Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point p1 = new Point();

            //Console.WriteLine("Input Point1 X");

            //p1.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Input Point1 Y");

            //p1.Y = double.Parse(Console.ReadLine());

            //Point p2 = new Point();

            //Console.WriteLine("Input Point2 X");

            //p2.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Input Point2 Y");

            //p2.Y = double.Parse(Console.ReadLine());


            //double distance = Math.Sqrt(Math.Pow((p2.X-p1.X),2) + Math.Pow((p2.Y-p1.Y),2));

            //Console.WriteLine(distance);


            //int.TryParse(c)

            #endregion


            #region 7- Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            // Person[] persons = new Person[3];


            // for (int i = 0; i < persons.Length; i++)
            // {
            //     Console.WriteLine("Enter Person Name then Enter then Age then Enter");
            //     persons[i] = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));

            // }



            //persons = persons.OrderByDescending(e => e.Age).ToArray();


            // Console.WriteLine(persons[0].Age);


            #endregion

            #region    Part 02 :Encapsulation

            //Employees[] EmpArr = new Employees[]
            //{
            //    new Employees { ID = 1 , Name="Khaled" , Gender = Gender.Male  ,Salary=2000, SecurityLevel=(SecurityLevel)8, HiringDate=new HiringDate(1,12,2024) },
            //    new Employees { ID = 1 , Name="Saied " , Gender = Gender.Male  ,Salary=3500, SecurityLevel=(SecurityLevel)1, HiringDate=new HiringDate(3,1,2024) },
            //    new Employees { ID = 1 , Name="Sayed" , Gender = Gender.Male  ,Salary=5000, SecurityLevel=(SecurityLevel)15, HiringDate=new HiringDate(1,5,2024) }

            //};

            //Console.WriteLine(EmpArr[0].ToString());
            //Console.WriteLine(EmpArr[0].HiringDate);


            #endregion

        }
    }
}
