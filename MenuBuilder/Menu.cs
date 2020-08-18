using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class Menu<T> : IMenu<T>
    {
        private Dictionary<T, IOption> _allOptions;
        private ISystem _system;
        private IValidation _validation;

        public Menu(Dictionary<T, IOption> allOptions, ISystem system, IValidation validation)
        {
            _allOptions = allOptions;
            _system = system;
            _validation = validation;
        }

        private void PrintMenu()
        {
            foreach (var option in _allOptions)
            {
                if (option.Key is int)
                {
                    _system.Write($"{option.Key} - {option.Value.OptionMessage}");
                }
                else
                {
                    _system.Write(option.Key.ToString());
                }
            }
        }

        private bool CheckUserInput(string userInput)
        {
            List<string> keys = _allOptions.Keys.Select(k => k.ToString()).ToList();

            return _validation.CheckUserInput(userInput, keys);
        }

        private void RunOption(string userInput)
        {
            _allOptions[(T)Convert.ChangeType(userInput, typeof(T))].Run();
        }

        public void RunMenu()
        {
            if (_allOptions.Count() > 0)
            {
                PrintMenu();

                string userInput = _system.ReadString();

                if (CheckUserInput(userInput))
                {
                    RunOption(userInput);
                }
                else
                {
                    _system.Write($"There is no option {userInput} in menu");
                }
            }
            else
            {
                _system.Write($"There is no options at all in this menu");
            }

            RunMenu();
        }
    }
}
