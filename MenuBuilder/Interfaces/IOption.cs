using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Interfaces
{
    public interface IOption
    {
        string OptionMessage { get; }
        void Run();
    }
}
