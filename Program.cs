using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
            //Task04();
            //Task05();
            //Task06();
            //Task07();
            //Task08();
            //Task09();
            //Task10();
            //Task11();
            //Task13();
            //Task14();
            //Task15();
            //TakeAwayTask();
            //Task16();
            //Task17();
            //Task18();
            //Task19();
            //SelfAssessmentTasks();
        }
        public static void Task01()
        {
            Console.Write("Hello World!!!");
            Console.Write("Hello World!!!");
            Console.ReadKey();
        }
        public static void Task02()
        {
            Console.WriteLine("Hello World!!!");
            Console.Write("Hello World!!!");
            Console.ReadKey();
        }
        public static void Task03()
        {
            int Number = 5;
            Console.Write("Your number in OOP code is : " + Number);
            Console.ReadLine();
        }
        public static void Task04()
        {
            string Line = "My project of OOP code.";
            Console.Write("Your written line in OOP code is : " + Line);
            Console.ReadLine();
        }
        public static void Task05()
        {
            char Word = 'W';
            Console.Write("Your word in OOP code is : " + Word);
            Console.ReadLine();
        }
        public static void Task06()
        {
            float Number = 5.5F;
            Console.Write("Your number in OOP code is : " + Number);
            Console.ReadLine();
        }
        public static void Task07()
        {
            int Number;
            Console.Write("Enter new number : ");
            Number = int.Parse(Console.ReadLine());
            Console.Write("The number you entered is : " + Number);
            Console.ReadKey();
        }
        public static void Task08()
        {
            float Number;
            Console.Write("Enter new number : ");
            Number = float.Parse(Console.ReadLine());
            Console.Write("The number you entered is : " + Number);
            Console.ReadKey();
        }
        public static void Task09()
        {
            string Line; ;
            Console.Write("Enter any line : ");
            Line = Console.ReadLine();
            Console.Write("The line you entered is : " + Line);
            Console.ReadKey();
        }
        public static void Task10()
        {
            float Length;
            float Area;
            Console.Write("Enter length : ");
            Length = float.Parse(Console.ReadLine());
            Area = Length * Length;
            Console.Write("The area of square is : " + Area);
            Console.ReadKey();
        }
        public static void Task13()
        {
            float Number = 0;
            float Sum = 0;
            while (Number != -1)
            {
                Console.Write("Enter any number : ");
                Number = float.Parse(Console.ReadLine());
                Sum = Sum + Number;
            }
            Sum = Sum + 1;
            Console.Write("The sum of all the entered numbers is {0}.", Sum);
            Console.ReadKey();
        }
        public static void Task11()
        {
            float Marks;
            Console.Write("Enter your marks : ");
            Marks = float.Parse(Console.ReadLine());
            if (Marks <= 50)
            {
                Console.Write("Alas!! You have failed.");
            }
            else
            {
                Console.Write("Congratulations!! You have passed.");
            }
            Console.ReadLine();
        }
        public static void Task12()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome Jack");
            }
            Console.ReadKey();
        }
        public static void Task14()
        {
            float Number = 0;
            float Sum = 0;
            do
            {
                Console.Write("Enter any number : ");
                Number = float.Parse(Console.ReadLine());
                Sum = Sum + Number;
            }
            while (Number != -1);
            Sum = Sum + 1;
            Console.Write("The sum of all the entered numbers is {0}.", Sum);
            Console.ReadKey();
        }
        public static void Task15()
        {
            float[] Number = new float[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter any number : ");
                Number[i] = float.Parse(Console.ReadLine());
            }
            if (Number[0] > Number[1] && Number[0] > Number[2])
            {
                Console.Write("{0} is greater.", Number[0]);
            }
            else if (Number[1] > Number[2] && Number[1] > Number[3])
            {
                Console.Write("{0} is greater.", Number[1]);
            }
            else if (Number[2] > Number[1] && Number[2] > Number[0])
            {
                Console.Write("{0} is greater.", Number[2]);
            }
            Console.ReadKey();
        }
        public static void TakeAwayTask()
        {
            int Age;
            int AgeCounter = 1;
            float PriceOfWashingMachine;
            float PriceOfToys;
            float USD = 0;
            float TotalUSD = 0;
            int Toys = 0;
            float ToysUSD = 0;
            int BroCount = 0;
            Console.Write("Enter Lily's age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of washing machine: ");
            PriceOfWashingMachine = float.Parse(Console.ReadLine());
            Console.Write("Enter Price of toys : ");
            PriceOfToys = float.Parse(Console.ReadLine());
            while (AgeCounter <= Age)
            {
                if (AgeCounter % 2 == 0)
                {
                    USD = USD + 10;
                    TotalUSD = TotalUSD + USD;
                    BroCount++;
                }
                if (AgeCounter % 2 != 0)
                {
                    Toys++;
                }
                AgeCounter++;
            }
            ToysUSD = Toys * PriceOfToys;
            TotalUSD = TotalUSD + ToysUSD - BroCount;
            if (PriceOfWashingMachine < TotalUSD)
            {
                TotalUSD = TotalUSD - PriceOfWashingMachine;
                Console.Write("Yes!!! You have {0} USD remaining.", TotalUSD);
            }
            else if (PriceOfWashingMachine > TotalUSD)
            {
                TotalUSD = PriceOfWashingMachine - TotalUSD;
                Console.Write("No!!! You require {0} USD to complete the purchase.", TotalUSD);
            }
            Console.ReadKey();
        }
        public static void Task16()
        {
            float Number01;
            float Number02;
            float Sum;
            Console.Write("Enter first number : ");
            Number01 = float.Parse(Console.ReadLine());
            Console.Write("Enter sec number : ");
            Number02 = float.Parse(Console.ReadLine());
            Sum = Addition(Number01, Number02);
            Console.Write("The sum of given numbers is {0}.", Sum);
            Console.ReadKey();
            float Addition(float Num01, float Num02)
            {
                float Add;
                Add = Num01 + Num02;
                return Add;
            }
        }
        public static void Task17()
        {
            string DataRecord;
            string Path;
            Path = "E:\\ObjectOrientedProgramming\\Week01\\DataFile.txt";
            if (File.Exists(Path))
            {
                StreamReader ReadDataFromFile = new StreamReader(Path);
                while ((DataRecord = ReadDataFromFile.ReadLine()) != null)
                {
                    Console.WriteLine(DataRecord);
                }
                ReadDataFromFile.Close();
            }
            else
            {
                Console.Write("Data file does not exist.");
            }
            Console.ReadKey();
        }
        public static void Task18()
        {
            string Path;
            Path = "E:\\ObjectOrientedProgramming\\Week01\\DataFile.txt";
            StreamWriter WriteDataToFile = new StreamWriter(Path, true);
            WriteDataToFile.WriteLine("My first attempt of entering data in a file using C-sharp.");
            WriteDataToFile.Flush();
            WriteDataToFile.Close();
        }
        public static void Task19()
        {
            bool Running = true;
            bool IsValid = true;
            string[] Users = new string[5];
            string[] Codes = new string[5];
            int Counter = 0;
            int UserAndCodeCount = 0;
            LoadData();
            while (Running)
            {
                string Choice;
                Choice = MainMenu();
                if (Choice == "1")
                {
                    LogIn();
                }
                else if (Choice == "2")
                {
                    SignUp();
                }
                else if (Choice == "3")
                {
                    Exit();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Invalid Choice");
                    Thread.Sleep(3000);
                }
            }
            string MainMenu()
            {
                Console.Clear();
                string Choice;
                Console.WriteLine("             Welcome to Black Hole");
                Console.WriteLine("                  1. LogIn");
                Console.WriteLine("                  2. SignUp");
                Console.WriteLine("                  3. Exit");
                Console.Write("                  Enter your choice : ");
                Choice = Console.ReadLine();
                return Choice;
            }
            void LogIn()
            {
                Console.Clear();
                string Username;
                string Password;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("               Enter Username : ");
                Username = Console.ReadLine();
                UsernameValidator(Username);
                if (IsValid == false)
                {
                    Console.Write("               Enter Password : ");
                    Password = Console.ReadLine();
                    PasswordValidator(Password);
                    if (IsValid == true)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("               Congratulations!!! You have logged in.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("               Invalid Password.");
                        Thread.Sleep(3000);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                   Invalid User ID.");
                    Thread.Sleep(3000);
                }
            }
            void SignUp()
            {
                Console.Clear();
                string Username;
                Console.WriteLine("Example : wa*****.com");
                Console.WriteLine();
                Console.Write("               Enter Username : ");
                Username = Console.ReadLine();
                UsernameValidator(Username);
                if (IsValid == true)
                {
                    Users[Counter] = Username;
                    Console.Write("               Enter Password : ");
                    Codes[Counter] = Console.ReadLine();
                    StoreData(Users[Counter], Codes[Counter]);
                    Counter++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("               User Already Exists.");
                    Thread.Sleep(3000);
                }
            }
            void UsernameValidator(string Username)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Users[i] == Username)
                    {
                        IsValid = false;
                        break;
                    }
                    else
                    {
                        IsValid = true;
                    }
                }
            }
            void PasswordValidator(string Password)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Codes[i] == Password)
                    {
                        IsValid = true;
                        break;
                    }
                    else
                    {
                        IsValid = false;
                    }
                }
            }
            void Exit()
            {
                Running = false;
            }
            void StoreData(string Username, string Password)
            {
                string UsernameDataPath;
                string UserPasswordDataPath;
                UsernameDataPath = "E:\\ObjectOrientedProgramming\\Week01\\Usernames.txt";
                StreamWriter AppendFile00 = new StreamWriter(UsernameDataPath, true);
                AppendFile00.WriteLine(Username);
                AppendFile00.Flush();
                AppendFile00.Close();
                UserPasswordDataPath = "E:\\ObjectOrientedProgramming\\Week01\\Passwords.txt";
                StreamWriter AppendFile01 = new StreamWriter(UserPasswordDataPath, true);
                AppendFile01.WriteLine(Password);
                AppendFile01.Flush();
                AppendFile01.Close();
            }
            void LoadData()
            {
                string UserRecord;
                string UsernameDataPath;
                string UserPasswordDataPath;
                UsernameDataPath = "E:\\ObjectOrientedProgramming\\Week01\\Usernames.txt";
                UserPasswordDataPath = "E:\\ObjectOrientedProgramming\\Week01\\Passwords.txt";
                if (File.Exists(UsernameDataPath))
                {
                    
                    StreamReader ReadFile = new StreamReader(UsernameDataPath);
                    while ((UserRecord = ReadFile.ReadLine()) != null)
                    {
                            Users[UserAndCodeCount] = UserRecord;
                            UserAndCodeCount++;
                    }
                    ReadFile.Close();
                    if (File.Exists(UserPasswordDataPath))
                    {
                        UserAndCodeCount = 0;
                        ReadFile = new StreamReader(UserPasswordDataPath);
                        while ((UserRecord = ReadFile.ReadLine()) != null)
                        {
                                Codes[UserAndCodeCount] = UserRecord;
                            UserAndCodeCount++;
                        }
                        ReadFile.Close();
                    }
                    else
                    {
                        Console.Write("User Password Data file does not exist.");
                        Thread.Sleep(3000);
                    }
                    ReadFile.Close();
                }
                else
                {
                    Console.Write("Username Data file does not exist.");
                    Thread.Sleep(3000);
                }
            }
        }
        public static void SelfAssessmentTasks()
        {
            string[] Customers = new string[2];
            int[] Orders = new int[2];
            int[] Credits01 = new int[10];
            int[] Credits02 = new int[8];
            int TotalPizzas;
            int TotalAmount;
            int CustomerAndOrderCount = 0;
            int CreditCount = 0;
            LoadPizzaPointsDataBase();
            PizzaPointDetails();
            PizzaPointCalculator();
            Console.ReadKey();
            void PizzaPointDetails()
            {
                Console.Write("Enter number of pizzas : ");
                TotalPizzas = int.Parse(Console.ReadLine());
                Console.Write("Enter total amount of all pizzas : ");
                TotalAmount = int.Parse(Console.ReadLine());
            }
            void LoadPizzaPointsDataBase()
            {
                string CustomerRecord;
                string CustomerDataPath;
                string OrderDataPath;
                string CustomerCreditDataPath01;
                string CustomerCreditDataPath02;
                CustomerDataPath = "E:\\ObjectOrientedProgramming\\Week01\\Customers.txt";
                OrderDataPath = "E:\\ObjectOrientedProgramming\\Week01\\Orders.txt";
                CustomerCreditDataPath01 = "E:\\ObjectOrientedProgramming\\Week01\\Credits01.txt";
                CustomerCreditDataPath02 = "E:\\ObjectOrientedProgramming\\Week01\\Credits02.txt";
                if (File.Exists(CustomerDataPath))
                {

                    StreamReader ReadFile = new StreamReader(CustomerDataPath);
                    while ((CustomerRecord = ReadFile.ReadLine()) != null)
                    {
                        Customers[CustomerAndOrderCount] = CustomerRecord;
                        CustomerAndOrderCount++;
                    }
                    ReadFile.Close();
                    if (File.Exists(OrderDataPath))
                    {
                        CustomerAndOrderCount = 0;
                        ReadFile = new StreamReader(OrderDataPath);
                        while ((CustomerRecord = ReadFile.ReadLine()) != null)
                        {
                            Orders[CustomerAndOrderCount] = int.Parse(CustomerRecord);
                            CustomerAndOrderCount++;
                        }
                        ReadFile.Close();
                        if (File.Exists(CustomerCreditDataPath01))
                        {
                            CreditCount = 0;
                            ReadFile = new StreamReader(CustomerCreditDataPath01);
                            while ((CustomerRecord = ReadFile.ReadLine()) != null)
                            {
                                Credits01[CreditCount] = int.Parse(CustomerRecord);
                                CreditCount++;
                            }
                            ReadFile.Close();
                        }
                        else
                        {
                            Console.Write("Customer's credit Data file does not exist.");
                            Thread.Sleep(3000);
                        }
                        ReadFile.Close();
                        if (File.Exists(CustomerCreditDataPath02))
                        {
                            CreditCount = 0;
                            ReadFile = new StreamReader(CustomerCreditDataPath02);
                            while ((CustomerRecord = ReadFile.ReadLine()) != null)
                            {
                                Credits02[CreditCount] = int.Parse(CustomerRecord);
                                CreditCount++;
                            }
                            ReadFile.Close();
                        }
                        else
                        {
                            Console.Write("Customer's credit Data file does not exist.");
                            Thread.Sleep(3000);
                        }
                        ReadFile.Close();
                    }
                    else
                    {
                        Console.Write("Customer's Order Data file does not exist.");
                        Thread.Sleep(3000);
                    }
                    ReadFile.Close();
                }
                else
                {
                    Console.Write("Customer's Data file does not exist.");
                    Thread.Sleep(3000);
                }
            }
            void PizzaPointCalculator()
            {
                Console.Clear();
                if (TotalPizzas < Orders[0] || TotalPizzas < Orders[1])
                {
                    for(int i = 0 ; i < 10 ; i++)
                    {
                        if(TotalAmount == Credits01[i])
                        {
                            Console.Clear();
                            Console.WriteLine(Customers[0]);
                            break;
                        }
                        if(TotalAmount != Credits01[i])
                        {
                            if(Credits01[i] % TotalAmount == 0)
                            {
                                Console.Clear();
                                Console.WriteLine(Customers[0]);
                                break;
                            }
                        }
                    }
                    for (int j = 0; j < 8; j++)
                    {
                        if (TotalAmount == Credits02[j])
                        {
                            Console.Write(Customers[1]);
                            break;
                        }
                        if(TotalAmount != Credits02[j])
                        {
                            if(Credits02[j] % TotalAmount == 0)
                            {
                                Console.Write(Customers[1]);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
