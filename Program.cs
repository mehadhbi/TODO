using System;
using static System.Console;

namespace TODO
{
    class Program
    {
        static void Main(string[] args)
        {

            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Add todo");
                WriteLine("2. ");
                WriteLine("3. Exit");

                ConsoleKeyInfo pressedKey = ReadKey(true);


                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:

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
