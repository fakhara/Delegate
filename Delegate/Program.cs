using System.Security.Cryptography.X509Certificates;

namespace Delegate
{/*
    //1- Print Message
    //delegate PrintMessage that takes a string parameter and returns void.
    public delegate void PrintMessage(string message);
     public class Program
     {
        //create a method PrintToConsole that matches the delegate's signature
        // instantiate the delegate and associate it with the PrintToConsole method.
        public static void PrintToConsole(string message)
       {
            Console.WriteLine(message);
       }
        static void Main(string[] args)
        {
            //invoke the method via the delegate instance.
            PrintMessage printMessageDel = new PrintMessage(PrintToConsole);
            printMessageDel("Hello World!");
        }
     }*/

    /*
     //2- Multicasting Delegate

     public delegate void PrintMessage(string message);

     public class Program
     {
         //delegate printMessageDel is associated with both PrintToConsole and PrintToFile methods.
         public static void PrintToConsole(string message)
         {
             Console.WriteLine("Console: " + message);
         }

         public static void PrintToFile(string message)
         {
             Console.WriteLine("File: " + message);
         }

         static void Main(string[] args)
         {
             //delegate is invoked, it calls both methods in the order they were added.
             PrintMessage printMessageDel = PrintToConsole;
             printMessageDel += PrintToFile;

             printMessageDel("Hello, Multicast!");
         }
     }*/

    
    //3-Console Menu System
    //MenuAction delegate represents any method that takes no parameters and returns void.

    public delegate void MenuAction();

       public class Program
       {
          public static void ShowDate()
          {
            Console.WriteLine("Current Date: " + DateTime.Now.ToShortDateString()); ;
          }
         
          public static void ShowTime()
          {
            Console.WriteLine("Current Time: " + DateTime.Now.ToLongTimeString());
          }
          public static void Exit()
          {
            Console.WriteLine("exiting the application..."); ;
          }
          static void Main(string[] args)
          {
            //Dictionary to map menu options (strings) to their corresponding actions (methods).
            Dictionary<string, MenuAction> menu = new Dictionary<string, MenuAction>
            {
                {"1", ShowDate },
                {"2", ShowTime },
                {"3", Exit }
            };

            while(true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Show Date");
                Console.WriteLine("2. Show Time");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Your choice:");
                string choice = Console.ReadLine();

                if(menu.ContainsKey(choice))
                {
                    menu[choice]();
                    if (choice == "3") break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again."); ;
                }
            }
          }
       }

}