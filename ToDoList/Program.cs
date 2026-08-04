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
                MenuDisplay();

                int choice = ReadInt("Enter Your Choice");

                switch (choice) {

                    case 1:
                        AddTask(ReadString("Enter Task"));
                        break;

                    case 2:
                        ViewTasks();
                        break;

                    case 3:
                        DeleteTask();
                        break;

                    case 4:
                        DeleteAllTasks();
                        break;

                    case 5:
                        MarkTaskAsCompleted();
                        break;

                    case 6:
                        ViewCompletedTasks();
                        break;

                    case 7:
                        DeleteCompletedTasks();
                        break;

                    case 8:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!");
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
        static void MenuDisplay() 
        {
            Console.WriteLine("1) Add Task\n2) View Tasks\n3) Delete Task\n4) Delete All Tasks\n5) Mark Task As Completed\n6) View Completed Tasks\n7) Delete Completed Tasks\n8) Exit");
        }

        static List<string> Tasks = new List<string>();
        static void AddTask(string task)
        { 
            Tasks.Add(task);
        }

        static void ViewTasks()
        {
            if (Tasks.Count != 0)
            {
                for (int i = 0; i < Tasks.Count; i++)
                {
                    Console.WriteLine($"{1 + i}. {Tasks[i]}");

                }
            }
            else
            {
                Console.WriteLine("No Tasks Available.");
            }
        }

        static void DeleteTask()
        {
            if (Tasks.Count != 0)
            {
                int choi = ReadInt("Enter Task Number To Delete");
                if (choi > 0 && choi<=Tasks.Count)
                {
                    Tasks.RemoveAt(choi - 1);
                }
                else
                {
                    Console.WriteLine("Invalid task number!!");
                }
            }
            else
            {
                Console.WriteLine("No Tasks Available.");
            }
        }

        static void DeleteAllTasks() {

            if (Tasks.Count != 0)
            {
                Tasks.Clear();
                Console.WriteLine("All Tasks Deleted.");
            }
            else
            {
                Console.WriteLine("No Tasks Available To Delete.");
            }
        }

        

        static List<string> CompletedTasks = new List<string>();

        static void MarkTaskAsCompleted()
        {
            if (Tasks.Count != 0)
            {
                ViewTasks();

                int choi = ReadInt("Enter Task Number To mark As Completed");

                if (choi > 0 && choi<=Tasks.Count)
                {
                    CompletedTasks.Add(Tasks[choi - 1]);
                    Tasks.RemoveAt(choi - 1);
                }
                else
                {
                    Console.WriteLine("Invalid task number!!");

                }
            }
            else
            {
                Console.WriteLine("No Tasks Available To Be Marked As Completed.");
            }
        }

        static void ViewCompletedTasks()
        {
            if (CompletedTasks.Count != 0)
            {
                for (int i = 0; i < CompletedTasks.Count; i++)
                {
                    Console.WriteLine($"{1 + i}. {CompletedTasks[i]}");

                }
            }
            else
            {
                Console.WriteLine("No  Completed Task Available.");
            }
        }

        static void DeleteCompletedTasks()
        {
            if (CompletedTasks.Count != 0)
            {
                CompletedTasks.Clear();
                Console.WriteLine("All Completed Tasks Deleted.");
            }
            else
            {
                Console.WriteLine("No Completed Tasks Available To Delete.");
            }
        }
    }
}
