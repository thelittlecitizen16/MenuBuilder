using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.Interfaces;


namespace MenuBuilder
{
    public class MenuOption<T> : IOption
    {
        public string OptionMessage { get; private set; }
        private IMenu<T> _menu;

        public MenuOption(IMenu<T> menu, string optionMessage)
        {
            OptionMessage = optionMessage;
            _menu = menu;
        }

        public void Run()
        {
            _menu.RunMenu();
        }
    }
}
