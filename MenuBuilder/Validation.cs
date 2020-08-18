using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class Validation : IValidation
    {
        public bool CheckUserInput(string userInput, List<string> allInputOptions)
        {
            return allInputOptions.Where(k => k.ToString() == userInput).Any();
        }
    }
}
