using System;
using TODO.Domain;
using static System.Console;

namespace TODO
{
    class Program
    {
        static Task[] taskList = new Task[100];

        static void Main(string[] args)
        {
            

            bool shouldNotExit = true;

            Task[] tasks = new Task[100];

            while (shouldNotExit)
            {
                Clear();

                WriteLine("1. Add todo");
                WriteLine("2. List todos");
                WriteLine("3. Exit");

                ConsoleKeyInfo pressedKey = ReadKey(true);

                Clear();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:

                        Write("Title: ");
                        string title = ReadLine();

                        Write("Due date (yy-mm-dd hh:mm): ");
                        DateTime dueDate = DateTime.Parse(ReadLine());

                        tasks[0] = new Task(title, dueDate);

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:
                        shouldNotExit = false;
                        break;
                }
            }

        }
    }
}
