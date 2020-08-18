using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Interfaces
{
    public interface IValidation
    {
        bool CheckUserInput(string userInut, List<string> allInputOptions);

    }
}
