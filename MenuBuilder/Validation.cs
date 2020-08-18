using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class Validation<T> : IValidation<T>
    {
        public bool CheckUserInput(string userInput, List<T> allInputOptions)
        {
            return allInputOptions.Where(k => k.ToString() == userInput).Any();
        }
    }
}
