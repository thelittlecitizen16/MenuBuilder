using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Interfaces
{
    public interface IValidation<T>
    {
        bool CheckUserInput(string userInut, List<T> allInputOptions);

    }
}
