using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Options
{
    public class PrintCitizenOption : IOption
    {
        public string OptionMessage => "Print citizen number";

        public void Run()
        {
            Console.WriteLine("TheLittleCitizen16");
        }
    }
}
