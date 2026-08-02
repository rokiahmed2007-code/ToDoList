using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Welcome To Your To Do List   ");

            bool isRunning = true;

            while (isRunning)
            {
                MenueDisplay();

                int choice = ReadInt("Enter Your Choice");

                switch (choice) {

                    case 1:
                        AddTask(ReadString("Enter Task"));
                        break;

                    case 2:
                        ViewTasks();
                        break;

                    case 3:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalide Choice!!");
                        break;

                }
                Console.ReadLine();
            }

            Console.ReadLine();

        }

        static string ReadString(string message)
        {
            Console.Write($"{message} :");
            return Console.ReadLine();
        }
        static int ReadInt(string message)
        {
            Console.Write($"{message} :");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void MenueDisplay()
        {
            Console.WriteLine("1) Add Task\n2) View Tasks\n3) Exit");
        }

        static List<string> Tasks = new List<string>();
        static void AddTask(string task)
        { 
            Tasks.Add(task);
        }
        static void ViewTasks()
        {
            for(int i = 0; i < Tasks.Count; i++)
            {
                    Console.WriteLine($"{1 + i}. {Tasks[i]}");
           
            }
        }
    }
}
