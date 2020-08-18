using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Interfaces
{
    public interface ISystem
    {
        string ReadString();
        int ReadInt();

        void Write(string message);
    }
}
