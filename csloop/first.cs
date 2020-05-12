using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class first
    {
        static void Main(String[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Write("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Write("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        break;


                }
            }
        }
}
