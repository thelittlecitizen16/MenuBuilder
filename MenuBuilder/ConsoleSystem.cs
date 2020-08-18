using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
   public class ConsoleSystem : ISystem
    {
        public string ReadString()
        {
            return Console.ReadLine();
        }
        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
