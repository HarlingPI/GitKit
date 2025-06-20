﻿using GitKit;

namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> modules = new List<string>()
            {
                "C:\\Users\\Harling\\Desktop\\PIToolKit"
            };

            Console.WriteLine($"已找到项目:");
            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine(modules[i]);
            }

            string[] commands = new[] { "pull" };

            for (int i = 0; i < modules.Count; i++)
            {
                for (int j = 0; j < commands.Length; j++)
                {
                    GitLib.ExcuteCommand(modules[i], commands[j]);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("'pull'已完成,请按任意键退出!");



            Console.Read();
        }
    }
}
