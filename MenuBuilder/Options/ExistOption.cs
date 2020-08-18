using System;
using System.Collections.Generic;
using MenuBuilder.Interfaces;
using System.Text;

namespace MenuBuilder
{
    public class ExistOption : IOption
    {
        public string OptionMessage => "Exist From Application";

        public void Run()
        {
            Environment.Exit(1);
        }
    }
}
