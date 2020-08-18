﻿using MenuBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class Menu<T> : IMenu<T>
    {
        public Dictionary<T, IOption> _allOptions;
        private ISystem _system;
        private IValidation<T> _validation;

        public Menu(Dictionary<T, IOption> allOptions, ISystem system, IValidation<T> validation)
        {
            _allOptions = allOptions;
            _system = system;
            _validation = validation;
        }

        private void PrintMenu()
        {
            foreach (var option in _allOptions)
            {
                _system.Write(option.Value.OptionMessage);
            }
        }

        private bool CheckUserInput(string userInput)
        {
            List<T> keys = _allOptions.Keys.ToList();

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
                _system.Write($"There is no options in this menu");
            }

            RunMenu();
        }
    }
}