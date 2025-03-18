using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using static System.Console;
using static System.Convert;
namespace Adv_c__revision
{
    internal class Program
    {
        #region Constants,Read-Only variables
        ////The const keyword is used to declare a constant field or a local constant. The value of a constant cannot be changed once it is declared and it also the value should be declared.
        //public const string MyStringConst = "Hello_World";
        //public const double PI = 3.14;
        //public const int MinutesPerHour = 60;
        ////The readonly means that is is only initialzied at declaration or inside a ctor
        //private static readonly string _Message="ssdsds";
        //static Program()
        //{
        //    _Message = "aaaa";            
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Split,Join,Format
            //// Example of using string.Format
            //int x = 3;
            //int y = 4;
            //WriteLine(string.Format("{0},{1}", x, y));

            //// Split a string into an array
            //Write("Enter the string:");
            //string input = ReadLine();
            //string[] arr1 = input.Split(' '); // Split the input string into an array of substrings separated by spaces
            //foreach (string element in arr1)
            //{
            //    WriteLine(element);
            //}

            //// Initialize an array with a specified size
            //Write("Enter the size of the array:");
            //int size = ToInt32(ReadLine());
            //string[] arr2 = new string[size]; // Initialize the array with the specified size

            //// Read elements of the array
            //Write("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    arr2[i] = ReadLine().Trim(); // Use Trim() to remove the newline character
            //}

            //// Print the arrays using string.Join
            //WriteLine("Array 1:");
            //WriteLine(string.Join(" ", arr1));
            //WriteLine("Array 2:");
            //WriteLine(string.Join(" ", arr2));
            #endregion
            #region inheritance
            //Child2 child = new Child2(11, 2, 4);
            //WriteLine(child.Sum());

            //Child c1 = new Child();
            //c1.X = 3;
            //c1.Y = 4;
            //WriteLine(c1.SumXYZ());

            #endregion
            #region Try Geoshape with issues
            //Issue 1
            // Code Wise is right
            // Buisness Wise is wrong
            //Square square = new Square(4);  /// dim1 => 4 , Dim2 = 4 
            ////we solved this with protected or private protected access modifiers for data variables
            //square.Dim1 = 3; /// dim1 3           
            //square.Dim2 = 6; /// dim1 3 dim2 6
            //WriteLine(square.CArea());

            /// Issue 2 geoshape is the parent so how can i create instance from it as if it is inherited so it makes no sense
            //GeoShape g1 = new GeoShape(3, 4);    // 8B

            // Code Wise => totally True
            // Buisness => Issue
            /// we wanna restrict create object from geoshape so we make it abstract class

            /// Abstract class : class we cannot create Object (new) from it
            /// 
            //GeoShape g1; // Zero , Reference // null //it is ok
            //GeoShape g2 = new GeoShape(); //it is not ok as it is abstract class
            #endregion
            #region dynamic and static binding
            //when i create a refrence variable that refers to an object in child it is called static binding
            //the o.s is responsible to retrieve an early copy of the refrence which makes no sense when calling overriden methods as it happened here it used the Show() function of the parent
            //So by logic we fix it using dynamic binding so it can get the the version of child instead using the virtual methods and override it with override keyword
            //Parent3 p1 = new Child3();
            //p1.Z = 3; //it is not allowed even if it is public property
            //p1.Show(); // Iam a parent
            //p1.ShowV2(); //Iam a child

            //Child3 child = new Child3();
            //child.Show();  // I am child 
            #endregion
            #region More issues with Geoshape in static binding

            //GeoShape g1 = new Rectangle(3, 4);
            //WriteLine(g1.CArea());
            //GeoShape g2 = new Circle(3);
            //WriteLine(g2.CArea());
            //GeoShape g3 = new Triangle(3, 5);
            //WriteLine(g3.CArea());

            //GeoShape g4 = new Rectangle(3, 4);
            //WriteLine(g4.CAreaV2());
            //GeoShape g5 = new Circle(3);
            //WriteLine(g5.CAreaV2());
            //GeoShape g6 = new Triangle(3, 5);
            //WriteLine(g6.CAreaV2());
            //GeoShape g7 = new Square(5);
            //WriteLine(g7.CAreaV2());

            #endregion
            #region Calculate SumAreas V01
            ////Violation of the open-close principle
            //Rectangle[] rectangles =
            //{
            //    new Rectangle(3,4),
            //    new Rectangle(2,5),
            //};
            //Square[] squares =
            //{
            //    new Square(10),
            //    new Square(10)
            //};
            //Triangle[] triangles =
            //{
            //    new Triangle(3, 4),
            //    new Triangle(4, 5)
            //};

            //Console.WriteLine(Utility.SumAreas(rectangles, squares, triangles));
            #endregion
            #region Calculate SumAreaV02
            //GeoShape[] geoShapes = new GeoShape[6]
            //{
            //    new Rectangle(3,4),
            //    new Rectangle(2,5),
            //    new Square(10),
            //    new Square(10),
            //    new Triangle(3,4),
            //    new Triangle(3,4),
            //};

            //Console.WriteLine(Utility.SumAreas2(geoShapes));
            #endregion
            #region Notes
            /// virtual can be overridden and to make virtual function must be overridden 

            /// we can use it as abstract method instead which is a method header Only => has no  body
            /// abstract method must exist in abstract class and the opposite is not right

            /// sealed class 
            /// class can inherits 
            /// and cann't be inherited
            /// 
            /// Editor 
            /// partial class 
            /// one class that distributed in several files 
            #endregion
            #region foreach
            //int[] arr = { 1, 2, 3, 4, 5 };
            //string[] Strr = { "x", "y", "z" };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            ////foreach iterate by itself ascending, deals with index by itself and allow to read only
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item); // arr[i]
            //}
            //foreach (string item in Strr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Value Type = Operator  => Assign State / Value 
            //int x;
            //Console.WriteLine(x);    /// Error

            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x);   // 10 
            //Console.WriteLine(y);   // 20 
            //x = y;
            //Console.WriteLine(x);   // 20 
            //Console.WriteLine(y);   // 20 
            //y = 55;
            //Console.WriteLine(x);   // 20
            //Console.WriteLine(y);   // 55
            #endregion
            #region Refernce Type => Object Class
            //object obj = new object();
            //Object obj1= new object();
            //string str = "ahmed";
            //string str1 = new string("");
            //Console.WriteLine(obj.GetType());
            //Console.WriteLine(obj.GetHashCode());
            //Console.WriteLine(obj1.GetHashCode());
            //obj = obj1; //here both refer at the same thing and so the garbage collector overhead will come sooner or later and kill the first object from memory
            //Console.WriteLine(obj.GetHashCode());
            //Console.WriteLine(obj1.GetHashCode());
            #endregion
            #region Enum
            //Gender g1;
            //g1 = Gender.Male;
            //Console.WriteLine(g1);
            #endregion
            #region Access Modifiers
            //public:can be accessed anywhere==>in the same assembly or different assembly or derived(inherited class) either inside the same assembly or in another assembly and it can be accessed inside the file of the program or within the scope of the class.
            //private:can be accessed in the scope of the class only==>it cannot be accessed inside another class derived or not or inside another assembly derived or not and it can be accessed inside the file of program.
            //protected:can be accessed in the scope of the class and it is derived classes no matter if it is in the same assembly or in a different assembly and it can be accessed in the scope of the program file.
            //internal:only inside the same assembly==> in  the scope of the class and it is derived classes and it also can be accessed in the same program file.
            //protected internal:can be accessed within the same file program or withing the same assembly either derived or none derived classes and derived classes different assembly it cannot be accessed from none derived classes in a different assembly.
            //private protected:same file program derived class within the assembly and in the scope of the class only.
            #endregion
            #region None Nullable Refrence Type
            //before .net6
            ////it is possible to create nullable refrence type
            //after .net6
            ///// normal behavior : when create refernce type 
            ///// it suppose to carry value not carry null 
            ///// not normal behavior : create refernce type carry null => warning 
            ///// with .net 6 => refernce Type became non nullable refernece type 
            ///// with .net 6 => We can create nullable refernce type
            #endregion
            #region properties
            //Student student = new Student();
            //At first we used to create our own setters and getters now it became easier that we use properties
            ///student.Id = 444;
            //Console.WriteLine(student.Id);

            //student.Id = 18888;
            //Console.WriteLine(student.Id);

            //student.Age = 20;
            //Console.WriteLine(student.Age);

            /// Automatic Property 
            /// Easy Implemntation for property if i will not change body of set or get
            #endregion
            #region Print user defined object
            ////int x = 44;

            ////Console.WriteLine(x);/// x.ToString();
            ////Console.WriteLine(x.ToString());

            //Student student = new Student();
            //Console.WriteLine(student.Print());
            //Console.WriteLine(student.ToString());
            //Console.WriteLine(student);   ///// student.Tostring()

            #endregion
            #region property Initiallizer 
            //Student student = new Student();
            //Student student1 = new Student(_id: 111, _salary: 5555, _name: "metwally", _age: 80);
            //int[] arr = new int[3] { 44,55,66};
            //Student student2 = new Student() { Age = 44, Id = 55, Name= "green", Salary = 87251 };

            #endregion
            #region Casting of value types into value type
            //int x = 10;      // 4B   // 2 Billion 
            //double y = 20;   // 8B   
            //x = int.MaxValue;
            //Console.WriteLine(x);
            //y = double.MaxValue;
            //Console.WriteLine($"double {y}");
            //int X = 2100000000;
            //int Y = 2_100_000_000;
            //////assign value of x into variable of y

            ////// casting
            ////// implicit casting : compiler will do itself
            ////// safe casting : compiler will do casting in all cases
            //y = x;
            //Console.WriteLine(y);

            /////////// explicit Casting : Developer will do casting by himself
            //y = (double)x;

            //////// explicit casting 
            //////// unsafe casting : compiler cann't do all cases   
            //x = (int)y;
            //Console.WriteLine("After casting ");
            //Console.WriteLine(x);


            //Console.WriteLine($"x = {x}");
            //Console.WriteLine($"x Type=> {x.GetType().Name}");
            //Console.WriteLine($"y = {y}");
            //Console.WriteLine($"y Type=> {y.GetType().Name}");
            #endregion
            #region Casting of value type into refrence type
            ////Boxing:means casting a value type into refrence type in heap like System.Object()
            //object o1 = new object();
            //int x = 30;
            //char ch='A';
            //o1 = x;
            //o1 = ch;
            //o1=false;
            //Console.WriteLine(o1);
            //Console.WriteLine(o1.GetType().FullName);
            ////Unboxing:casting from System.Object to value type
            ////unsafe casting as it is done by developer
            //bool flag = (bool)o1;
            //Console.WriteLine($"o1=>{o1}");
            //Console.WriteLine($"flag{flag}");
            //Console.WriteLine(o1.GetType().FullName);
            //Console.WriteLine(flag.GetType().FullName);
            #endregion
            #region var
            //As we know c# is strongly typed when declare any variable with specific Data type,it will still be until the end.
            //var is a keyword and not a data type
            //var x = 3;
            //var y = 23.5;
            //Console.WriteLine(y.GetType().FullName);
            //Console.WriteLine(x.GetType().FullName);
            #endregion
            #region Dynamic
            //It is used when we migrate projects using different languages.
            //It is big issue as it is slow as it only function in runtime of the program.
            //dynamic x = 44;
            //x = 23.5;
            //Console.WriteLine(x.GetType().FullName);
            #endregion
            #region nullable value types
            //Practically in databases such as sql DB  if i have data of employees or students,etc the most important factor may be ID and some of the others may be nullable
            //Value types cannot be nullable by default
            //int x = null; //Wrong
            //int? x = null; //Right
            //Checking whether the value is null or not
            ////V01
            //if(x!=null)
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("empty");
            //}
            ////V02
            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("empty");
            //}
            //HasValue only in int not in double or string
            //Console.WriteLine(x.HasValue ? x.Value : "Empty"); //using ternary operator
            // V04
            //Console.WriteLine(x??-1); //using null-coalescing
            #endregion
            #region default & null propagation operator
            //int x = default;  // 0
            //string str = default;   // null
            //int[] arr = default;  // null

            //Console.WriteLine(x);
            //Console.WriteLine(str.Length);   //Object reference not set to an instance of an object.

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr);
            //}

            //if (str != null)
            //{
            //    Console.WriteLine(str.Length);
            //}
            //else
            //{
            //    Console.WriteLine("Empty !!!");
            //}

            //for (int i = 0; arr != null  && i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine(str?.Length);

            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            // Console.WriteLine(str??"Not Found");

            //arr[3] = 5; /// Error
            //arr = new int[5]; 
            //arr[3] = 5;
            //(arr ??=new int[10])[3] = 55;
            //Console.WriteLine(arr[3]);
            #endregion
            #region NamedParemters
            //Console.WriteLine(MyMath.Add(10, 20, 30));
            //MyMath.Add(z: 10, y: 30, x: 20);
            //Student student = new Student(_id: 111, _salary: 55, _name: "", _age: 44);
            #endregion
            #region Static methods,Static classes,Static constructors,Static variables
            //static class: each member inside the class should be static and it cannot be inherited or instanited
            //static constructor: it is used to initiate static variables,has no return type and access modifiers are not allowed as no one is allowed to call the static constructor and has no overloading
            //static variable:are variables that can be modified with static constructor
            #endregion
            #region ref,out
            //int x = 3;
            //int y=4;
            //int z=0;
            //Utility.Swap(x, y); //pass by value which is readonly
            //Console.WriteLine(x); System.Console.WriteLine(y);
            //Utility.SwapRef(ref x ,ref y); //pass by refrence which is read and write 
            //Console.WriteLine(x); System.Console.WriteLine(y);
            //Utility.Add(x, y,ref z);
            //Console.WriteLine(z);
            //int l;
            //Utility.AddV02(x, y,out l);
            //System.Console.WriteLine(l);

            #endregion
            #region Parse,TryParse,Convert
            //int x;
            //int result;
            //x = int.Parse(Console.ReadLine()); //doesn't handle all cases as i may write string
            //if(int.TryParse(Console.ReadLine(),out result))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}
            //int y;
            //y=int.Parse(Console.ReadLine()); ;
            //y=Convert.ToInt32(Console.ReadLine());
            #endregion
            #region ctor with different version of .NET
            //struct is a value type
            //with .net 5 ->
            //there is implicit parameterless ctor you cannot write it explicitly
            //explicit parameter ctor must fully initialize fields

            //with .net 6
            //there is implicit parameterless ctor and  you can write it explicitly
            //explicit parameter and parameterless ctor must fully initialize fields

            //with .net 7
            //there is implicit parameterless ctor and  you can write it explicitly
            //explicit parameter and parameterless ctor may not be fully initialize fields

            //struct cannot inherit and cannot be inherited 

            #endregion
            #region Singleton
            //Singleton o1 = Singleton.CreateObject();
            //Singleton o2 = Singleton.CreateObject();
            //Singleton o3 = Singleton.CreateObject();
            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());
            //Console.WriteLine(o3.GetHashCode());
            #endregion
            #region Complex Declaration
            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(3, 4);
            //Complex c3 = new Complex(5, 6);

            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Complex Result = new();
            //Result = c1.Add(c2);
            //Console.WriteLine(Result.ToString());
            #endregion
            #region Operator Overload
            //Complex c1 = new Complex(3,4); 
            //Complex c2 = new Complex(5,6);
            //Complex c3 = c1 + c2;            #endregion
            //int x = 3;
            //int y = 4;
            //int result = x + y;//int.operator +(x,y);
            //the compiler interpret it as int operator+(int left,int right)
            //I want to define an operator that adds two complex number so in OOP we have something called operator overload which overloads the normal operator + to an operator i can use in this situation.
            //Complex c1 = new(1,2);
            //Complex c2 = new(2,3);
            //Complex Result=new();
            //Result = c1 + c2;
            //Console.WriteLine(Result.ToString());
            //if(c1 > c2) { 
            //    Console.Write("greater"); 
            //}
            //else
            //{
            //    Console.WriteLine("not greater");
            //}
            //if (c1 == c2) {
            //    Console.Write("equal");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //}
            //string s1 = new string("aaaa");
            //s1 = (string)c1;
            //Console.WriteLine(s1);
            #endregion
            #region Refrence Type check Equality ==,Equals , static Equals,static RefrenceEquals
            //Point2d p1 = new Point2d(3,4);
            //Point2d p2 = new Point2d(4,6);
            //Point2d p3 = new Point2d(3, 4);
            //Point2d p4 = p1;
            // == => Check Identity [HashCode]
            // Equals => Check Identity [HashCode]
            // Static Equals => Check Identity [HashCode]
            // Static ReferenceEquals => Check Identity [HashCode]

            //if (System.Object.Equals(s1,s3)) //before override
            //{

            //    Console.WriteLine("EQ");
            //}
            //else
            //{
            //    {
            //        Console.WriteLine("NEQ");
            //    }
            //}
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p4.GetHashCode());
            //Console.WriteLine(p3.GetHashCode());

            ////Equals checks the identity equality [hashcode]
            ////StaticEquals checks the identity [hashcode]
            //if (p1.Equals(null))
            //{

            //    Console.WriteLine("EQ");
            //}
            //else
            //{
            //    {
            //        Console.WriteLine("NEQ");
            //    }
            //}

            #endregion
            #region Demo_Task
            //.	Design and implement a structure for the employees in a company 
            //.	Employee is identified by an ID, security level, salary, hire date and Gender.
            //.	Develop a Structure to represent the HiringDate Data Type consisting of fields to hold the day, month and Years.
            //.	We need to restrict the Gender field to be only M or F [Male of Female] (Use Enum.Parse)
            //. Assign the security privileges to the employee in a form of byte Flag enum, security privileges are guest, Developer, secretary and DBA.
            //.	We want to provide the Employee structure with the standard capabilities to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [use String.Format Function, do you need additional using Directive ]

            ////not handling all cases just simple code to test
            //Employee e1 = new Employee();
            //Console.WriteLine("Enter Id");
            //e1.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //e1.Name= Console.ReadLine();
            //Console.WriteLine("Enter Age");
            //e1.Age= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Gender");
            //e1.Gender=(Gender)Enum.Parse(typeof(Gender),Console.ReadLine());
            #endregion
            #region string
            ////string is Immutable data type so when we create object from string it will be allocated in a specific place in memory
            ////If we change value of string the new string will override the old string we had created before in memory(heap) and the old object will be deleted by the garbage collector overhead
            //string str = new string("Ahmed");
            //Console.WriteLine(str);
            //int age = 50;
            //Console.WriteLine("Yor name is " + str + " and your age is " + age);/// Memory OverHead
            //Console.WriteLine($"Yor name is {str} and your age is {age}"); //better way
            //StringBuilder sb = new StringBuilder();
            //sb.Append("ahmed");
            //sb.Append(" sameh");
            //Console.WriteLine(sb);
            #endregion
            #region Mutable Object
            //mutable means that if any modification happens to an object it happens at the same place in the memory

            //MutablePoint m1 = new MutablePoint(1, 2);
            //Console.WriteLine(m1);
            //Console.WriteLine(m1.GetHashCode());

            //m1.X = 8;
            //m1.Y = 9;
            //Console.WriteLine(m1);
            //Console.WriteLine(m1.GetHashCode());

            #endregion
            #region Immutable Object
            //ImmutablePointV01 p1 = new ImmutablePointV01(1, 2);
            //p1.X = 1;
            //p1.Y = 2;
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.GetHashCode());

            //p1 = new ImmutablePointV01(44, 55);
            //Console.WriteLine(p1);
            ////Console.WriteLine(p1.GetHashCode());

            //ImmutablePointV02 im1 = new ImmutablePointV02() { X = 55, Y = 55 };
            //Console.WriteLine(im1.X);
            //Console.WriteLine(im1.Y);
            //Console.WriteLine(im1.GetHashCode());

            ////im1.X = 44;
            ////im1.Y = 44;

            //ImmutablePointV02 im2 = new ImmutablePointV02() { X = 33, Y = 44 };
            //Console.WriteLine(im2.X);
            //Console.WriteLine(im2.Y);
            //Console.WriteLine(im2.GetHashCode());
            #endregion
            #region Interface
            //Instructor i1 = new Instructor();
            //Instructor i2 = new Instructor();
            //((IInterface1)i1).Add(4, 5);
            //WriteLine(((IInterface1)i1).Add(4, 5));
            //(i2 as IInterface2).Add(4, 5);
            //WriteLine((i2 as IInterface2).Add(4, 5));
            #endregion
            #region Sort Array for built-in DT
            //int[] arr = { 5, 1, 2, 6, -5, -7, 85, 4, 8, 54, 5 };
            //string[] strings = { "Ramy", "Andrew", "Ziad", "Sara", "Ahmed", "Osama" };

            //WriteLine("Before sorting:");
            //WriteLine(string.Join(", ", arr));
            //WriteLine(string.Join(", ", strings));

            //Array.Sort(arr);
            //Array.Sort(strings);

            //WriteLine("After sorting:");
            //WriteLine(string.Join(", ", arr));
            //WriteLine(string.Join(", ", strings));
            #endregion
            #region Sort Array for User-Defined DT(Array of Employees)
            //Employee[] employees = Array.Empty<Employee>(); //initialize array with size of 0
            //while (true)
            //{
            //    Write("Enter the number of employees: ");
            //    string? numEmployeesStr = ReadLine();
            //    int NumEmployees;
            //    while (!int.TryParse(numEmployeesStr, out NumEmployees) || NumEmployees < 0 || NumEmployees ==0)
            //    {
            //        WriteLine("Invalid input. Please enter a non-negative integer ");
            //        Write("Enter the number of employees: ");
            //        numEmployeesStr = ReadLine();
            //    }

            //    Employee[] NewEmployees = new Employee[NumEmployees]; //define an array for new employees
            //    if (NumEmployees == 0) //if number of employees = 0 break out of the loop
            //    {
            //        break;
            //    }
            //    for (int i = 0; i < NumEmployees; i++) //taking employees data
            //    {
            //        Write("Enter Name: ");
            //        string? name = ReadLine();
            //        while (string.IsNullOrWhiteSpace(name))
            //        {
            //            WriteLine("Name cannot be null or empty. Please try again.");
            //            Write("Enter Name: ");
            //            name = ReadLine();
            //        }

            //        int id;
            //        while (true)
            //        {
            //            Write("Enter Id: ");
            //            string? IdStr = ReadLine();
            //            if (string.IsNullOrWhiteSpace(IdStr))
            //            {
            //                WriteLine("ID cannot be null or empty. Please try again.");
            //                continue;
            //            }
            //            if (int.TryParse(IdStr, out id))
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                WriteLine("Invalid ID. Please enter a valid integer.");
            //            }
            //        }

            //        int age;
            //        while (true)
            //        {
            //            Write("Enter Age: ");
            //            string? ageStr = ReadLine();
            //            if (string.IsNullOrWhiteSpace(ageStr))
            //            {
            //                WriteLine("Age cannot be null or empty. Please try again.");
            //                continue;
            //            }
            //            if (int.TryParse(ageStr, out age) && age > 0)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                WriteLine("Invalid age. Please enter a positive integer.");
            //            }
            //        }
            //        Gender gender;
            //        while (true)
            //        {
            //            Write("Enter Gender (Male/Female/Unknown or M/F/U): ");
            //            string input = ReadLine().ToUpper();
            //            //try is a block that takes the code that may cause system exception
            //            //catch block handles the exception
            //            try
            //            {
            //                switch (input)
            //                {
            //                    case "M":
            //                    case "MALE":
            //                        gender = Gender.Male;
            //                        break;
            //                    case "F":
            //                    case "FEMALE":
            //                        gender = Gender.Female;
            //                        break;
            //                    case "U":
            //                    case "UNKNOWN":
            //                        gender = Gender.Unknown;
            //                        break;
            //                    default:
            //                        throw new Exception("Invalid input. Please enter Male, Female, Unknown, M, F, or U.");
            //                }
            //                break;
            //            }
            //            catch (Exception ex)
            //            {
            //                WriteLine(ex.Message);
            //            }
            //        }

            //        Write("Enter the salary of the employee: ");
            //        string? salaryStr = ReadLine();
            //        decimal salary;
            //        while (!decimal.TryParse(salaryStr, out salary) || salary < 0)
            //        {
            //            WriteLine("Invalid input. Please enter a non-negative decimal number.");
            //            Write("Enter the salary of the employee: ");
            //            salaryStr = ReadLine();
            //        }

            //        Write("Enter the department ID: ");
            //        int deptId = ToInt32(ReadLine());

            //        Console.Write("Enter the department name: ");
            //        string? deptNameStr;
            //        Department dept;
            //        while (true)
            //        {
            //            deptNameStr = ReadLine();
            //            if (string.IsNullOrWhiteSpace(deptNameStr))
            //            {
            //                WriteLine("Department name cannot be null or empty. Please try again.");
            //                continue;
            //            }
            //            try
            //            {
            //                DepartmentName deptEnum = (DepartmentName)Enum.Parse(typeof(DepartmentName), deptNameStr, true);
            //                Write("Enter the department description: ");
            //                string? deptDesc = Console.ReadLine();
            //                dept = new Department(deptId, deptEnum, deptDesc);
            //                break;
            //            }
            //            catch (ArgumentException)
            //            {
            //                WriteLine("Invalid department name. Please enter one of the following: IT, Engineering, CustomerService, Management, HR, or Unknown.");
            //            }
            //        }
            //        int year;
            //        while (true)
            //        {
            //            Write("Enter the year of hire date: ");
            //            string yearInput = ReadLine();
            //            if (int.TryParse(yearInput, out year) && year > 0)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                WriteLine("Invalid year. Please enter a positive integer.");
            //            }
            //        }

            //        int month;
            //        while (true)
            //        {
            //            Write("Enter the month of hire date: ");
            //            string monthInput = Console.ReadLine();
            //            if (int.TryParse(monthInput, out month) && month > 0 && month <= 12)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                WriteLine("Invalid month. Please enter a number between 1 and 12.");
            //            }
            //        }

            //        int day;
            //        while (true)
            //        {
            //           Write("Enter the day of hire date: ");
            //            string dayInput = ReadLine();
            //            if (int.TryParse(dayInput, out day) && day > 0 && day <= 31)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                WriteLine("Invalid day. Please enter a number between 1 and 31.");
            //            }
            //        }

            //        if (month == 2)
            //        {
            //            if (day > 28)
            //            {
            //                WriteLine("February only has 28 days. Using 28 as the day.");
            //                day = 28;
            //            }
            //        }
            //        else if (month == 4 || month == 6 || month == 9 || month == 11)
            //        {
            //            if (day > 30)
            //            {
            //                WriteLine("This month only has 30 days. Using 30 as the day.");
            //                day = 30;
            //            }
            //        }

            //        HireDate hireDate = new HireDate(year, month, day);

            //        SecurityPrivileges securityPrivileges;
            //        while (true)
            //        {
            //            Write("Enter Security Privileges (Guest, Developer, Secretary, DBA or G/D/S/DB): ");
            //            string input = ReadLine().ToUpper();

            //            try
            //            {
            //                switch (input)
            //                {
            //                    case "G":
            //                    case "GUEST":
            //                        securityPrivileges = SecurityPrivileges.Guest;
            //                        break;
            //                    case "D":
            //                    case "DEVELOPER":
            //                        securityPrivileges = SecurityPrivileges.Developer;
            //                        break;
            //                    case "S":
            //                    case "SECRETARY":
            //                        securityPrivileges = SecurityPrivileges.Secretary;
            //                        break;
            //                    case "DB":
            //                    case "DBA":
            //                        securityPrivileges = SecurityPrivileges.DBA;
            //                        break;
            //                    default:
            //                        throw new Exception("Invalid input. Please enter Guest, Developer, Secretary, DBA, G, D, S, or DB.");
            //                }

            //                // Now you can use the securityPrivileges variable
            //                WriteLine("You entered: " + securityPrivileges);
            //                break;
            //            }
            //            catch (Exception ex)
            //            {
            //                WriteLine(ex.Message);
            //            }
            //        }
            //        Employee e = new Employee(name, age, salary, securityPrivileges, new HireDate(year, month, day), gender, dept);
            //        e.Id = id;
            //        e.Salary = salary;
            //        NewEmployees[i] = e;
            //    }

            //    ////define a new array to append values to this database
            //    Employee[] temp = new Employee[employees.Length + NewEmployees.Length];
            //    Array.Copy(employees, 0, temp, 0, employees.Length);
            //    Array.Copy(NewEmployees, 0, temp, employees.Length, NewEmployees.Length);
            //    employees = temp;
            //    Array.Sort(employees);
            //    ////print the updated list of employees
            //    foreach (Employee item in employees)
            //    {
            //        WriteLine(item.ToString());
            //    }
            //}
            #endregion
            #region Built-In Clone Object From Another one
            //int[] arr = { 5, 1, 2, 6, -5, -7, 85, 4, 8, 54, 5 };
            //string[] strings = { "Ramy", "Andrew", "Ziad", "Sara", "Ahmed", "Osama" };

            //int[] arr2 = arr;

            //arr[3] = 7700;
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr2[3]);

            //Console.WriteLine(arr.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //Console.WriteLine(string.Join(",", arr));
            //Console.WriteLine(string.Join(",", arr2));

            //int[] temp = arr.Clone() as int[];
            //Console.WriteLine(string.Join(",", temp));

            //Console.WriteLine(arr.GetHashCode());
            //Console.WriteLine(temp.GetHashCode());
            //arr[0] = 88888;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(temp[0]);
            #endregion
            #region Cloning User-Defined DT
            //Employee e1 = new Employee() { Id = 5, Name = "Ziad", Age = 22, Gender = Gender.Male, Department = new Department(11, DepartmentName.IT, "sds"), HireDate = new HireDate(2000, 2, 3) };

            //Employee e2 = e1.Clone() as Employee;

            //e1.Department.DeptName = DepartmentName.IT;
            //e1.HireDate = new HireDate(2000, 2, 3);

            //Console.WriteLine(e1);
            //Console.WriteLine(e1.GetHashCode());
            //Console.WriteLine(e2);
            //Console.WriteLine(e2.GetHashCode());

            //Console.WriteLine(e1.Department.DeptName);
            //Console.WriteLine(e2.Department.DeptName);
            //Console.WriteLine(e1.HireDate.Date.Year);
            //Console.WriteLine(e2.HireDate.Date.Year);
            #endregion
            #region NoneGeneric DT
            //MyStack m1 = new MyStack();
            //m1.Push(1);
            //m1.Push(2);
            //m1.Push(3);
            //WriteLine(m1.Pop());
            //WriteLine(m1.Pop());
            //WriteLine(m1.Pop());
            //WriteLine(m1.Pop());
            //m1.Push("test"); //none generic

            #endregion
            #region Generic DT
            //you can write once and do more as this data type will be applicable with more data types
            //none generic
            //MyStackV02<string> m2 = new();

            //m2.Push("test");
            //WriteLine(m2.Pop());


            #endregion
            #region None Generic Actions
            //int[] arr = {5,1,6,7,2,3,9,10,2,4,4,8};
            //Draft.SortArray(arr);
            //WriteLine(string.Join(",", arr));
            //WriteLine(Draft.SearchArray(arr, 5));
            //string[] s1 = ["ahmed", "mohammed", "test"];

            ////it is none generic
            //Draft.SortArray(s1);
            //WriteLine(Draft.SearchArray(s1, "ahmed"));




            #endregion
            #region Generic Actions
            //int x = 11;
            //int y = 12;
            //string str = "first";
            //string str2 = "second";
            //double d = 44; double d1 = 55;
            //Trial<int>.Swap(ref x,ref y);  
            //Trial<double>.Swap(ref d,ref d1);

            //Trial2.Swap<int>(ref x,ref y);
            //Trial2.Swap(ref x,ref y);
            //Trial2.Swap<string>(ref str,ref str2);
            //Trial2.Swap(ref str,ref str2);
            #endregion
            #region Generic Collections => List 
            //List<int> ints = new List<int>(5);

            //// WriteLine(ints.Capacity);
            // ints.Add(1);
            // ints.Add(2);
            // ints.Add(3);
            // ints.Add(4);
            // ints.Add(5);

            // ints.Add(6);
            // ints.Add(7);
            // ints.Add(8);
            // ints.Add(9);
            // ints.Add(10);
            //// WriteLine(ints.Capacity); //10     // duplicate capacity
            // ints.Add(11);
            // WriteLine(ints.Capacity); //20 
            // ints.TrimExcess();
            // WriteLine(ints.Capacity);  //11
            // ints.Add(12);
            // WriteLine(ints.Capacity);  //22
            // //foreach (var item in ints)
            // //{
            // //    Console.WriteLine(item);
            // //}
            //// WriteLine(ints.Capacity); // duplicate capacity
            // List<string> strings = new List<string>();  


            // You can use indexer like array
            // GET , Update
            //List<int> ints = new List<int>() {1,2,3,4,5,6,7 };

            //ints[1] = 105;
            //ints.Add(99);
            //ints.Remove(99);
            //ints.RemoveAt(0);
            //Console.WriteLine(ints[0]);
            //Console.WriteLine(ints[1]);
            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}


            ////int[] ints1 = new int[5];
            ////ints1[0]= 1;     // Set
            ////ints1[0]= 100;   // Update
            ////Console.WriteLine(ints[0]);    // Get 
            //List<int> ints = new List<int>() { 1,2,3,4,5,6,6};
            //List<int> ints1 = new List<int>();

            //ints1.AddRange(new int[] {1,2,3,4});
            //ints1 = [.. new int[] { 11, 22, 33 }];

            //List<GeoShape> geoShapes = new List<GeoShape>() { new GeoShape()};    

            #endregion
            #region Generic Collection => Dictionary collection of unique key : value
            //Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            //phoneBook.Add("Ali", 010);
            //phoneBook.Add("Sara", 011);
            //phoneBook.Add("Mona", 012);
            //phoneBook.Add("Habiba", 013);
            //phoneBook.Add("Ramy", 014);
            ////phoneBook.Add("Ali",010);     // Exception

            //if (phoneBook.TryAdd("Ali", 018))
            //{
            //    Console.WriteLine("Done");
            //}
            //else
            //{
            //    // update
            //    phoneBook["Ali"] = 10000;
            //}

            //// phoneBook["Ali"] = 546556;  // update
            //phoneBook["Hoda"] = 444; // insert

            //foreach (var item in phoneBook)
            //{
            //    Console.WriteLine($"{item.Key},{item.Value}");
            //}

            #endregion
            #region filteration v01
            ////before knowing delegates we used to do this
            //var employees = Repo.Employees;
            //List<Employee2> employees_filtered= Filteration.FilterByAny(employees);
            //foreach (var employee in employees_filtered)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion
            #region Delegate
            //Delegate is a pointer to a function or a variable that carries a function
            //var employees = Repo.Employees;
            #region Delegate v01
            //MyDelegate del = new MyDelegate(Trial3.BySalary);

            //MyMathDelegate del1 = new MyMathDelegate(Trial3.Div);

            //MyDelegate1 del2 = new MyDelegate1(Trial3.PrintEmployee);

            //Employee2 e1 = employees[0];

            //Console.WriteLine(Trial3.BySalary(e1));
            //Console.WriteLine(del(e1));

            //Console.WriteLine(Trial3.Add(4, 5));
            //Console.WriteLine(del1(44, 55));
            //// Delegate act like function 

            //Trial3.PrintEmployee(e1);
            //del2(e1);

            #endregion
            #region Delegate V02
            //MyDelegate del3 = new MyDelegate(Trial3.IsOldEmployee);
            //MyDelegate del4 = Trial3.IsOldEmployee;

            ////new Employee(); // anonymous object

            //// anonymous function 
            //// calling with delegate Variable
            //MyMathDelegate del5 = delegate (int left, int right) { return left + right; };

            //MyDelegate1 del6 = delegate (Employee2 xyz) { Console.WriteLine("Done"); };

            //MyDelegate del7 = delegate (Employee2 xyz) { return xyz.Name.ToLower().Contains('a') && xyz.Salary > 2000; };
            //Employee2 e2 = employees[0];
            //WriteLine(del4(e2));
            //del3(e2);

            ////when declare delegate I want to implement Direct Body inside delegate
            #endregion
            #region Lambda expression
            //MyMathDelegate del1= delegate (int x,int y) {  return x + y; };
            //MyMathDelegate del2 =  (int x, int y) => { return x + y;};
            //MyMathDelegate del3 = (x, y) =>  x * y;
            //WriteLine(del3(3,4));


            #endregion
            #endregion
            #region Filteration v02
            //var employees = Repo.Employees;
            //MyDelegate del = (employee) => employee.Name.ToLower().Contains('s');
            //List<Employee2> filtered_employees= Filteration.FilterByAnyV02(employees,del);
            //foreach(var employee in filtered_employees) {
            //    Console.WriteLine(employee);
            //}

            #endregion
            #region Generic delegates
            ////GenericDelegate1 del = new ADVCSD07.GenericDelegate1();
            //GenericDelegate1<int> del = x => Console.WriteLine(x);
            //GenericDelegate1<string> del1 = x => Console.WriteLine(x);
            //// del = x => cw(x);
            //del1("Test");
            //del(55);

            //Employee employee = employees[0];
            //GenericDelegate2<Employee> del2 = e => e;
            //GenericDelegate3<int, string> del = x => "Test";

            //Console.WriteLine(del(555)); 
            //Console.WriteLine(del2(employee));
            //del2(employee);
            #endregion
            #region Built-in Delagets 

            #region Predicate
            //var employees = Repo.Employees;
            //Predicate<Employee2> del = x => x.DeptId==1;
            //Employee2 employee = employees[0];

            //Console.WriteLine(del(employee));
            //del(employee);
            #endregion

            #region Action 
            //Action action = () => Console.WriteLine("Test");
            //Action<int,int> action1 = (x,y) => Console.WriteLine($"{x},{y}");

            //action1(44,55);


            //action();
            #endregion

            #region FunC
            //Func<int> func = () => 1;
            //Func<string, string, int> del = (x, y) => 111;
            //Func<int, bool> func2 = x => false;

            //Console.WriteLine(func2(4));

            //Console.WriteLine(del("test", "test1"));

            //Console.WriteLine(func());
            //func();
            #endregion

            #endregion
            #region Delegate-Multicasting
            ////Action<double, double> action = (x, y) => WriteLine($"{x+y}");
            ////action += (x, y) => WriteLine($"{x * y}");
            ////action += (x, y) => WriteLine($"{x / y}");

            ////action.Invoke(1, 5);
            //////////////////////////////////////////////////
            //Func<double, double, double> func = (x, y) => x + y;
            //func += (x, y) => x - y;
            //func += (x, y) => x * y;
            //func += (x, y) => x / y;

            ////// Over Write
            //WriteLine(func(22, 11)); // double
            //Action<int> action1 = default;   // Null 
            ////action1(55);   // Unprotective Code    

            ////action1.Invoke(55);

            //if (action1 != null)
            //{
            //    action1(77);
            //}
            //else
            //{
            //    WriteLine("Sorry");
            //}

            //// Null Propagation Operator
            //action1?.Invoke(55);
            #endregion
        }
    }
}
