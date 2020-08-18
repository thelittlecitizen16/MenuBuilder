using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuBuilder.Interfaces;

namespace MenuBuilder_Example
{
    public class Option1 : IOption
    {
        public string OptionMessage => "Add Two Numbers";

        public void Run()
        {
            Console.WriteLine("hii");
        }
    }
}
