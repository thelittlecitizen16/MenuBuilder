using System;
using System.Collections.Generic;
using MenuBuilder.Interfaces;
using System.Text;

namespace MenuBuilder.Options
{
    public class ExitOption : IOption
    {
        public string OptionMessage => "Exit From Application";


        public void Run()
        {
            Environment.Exit(1);
        }
    }
}
