using System;
using System.Collections.Generic;
using MenuBuilder;
using MenuBuilder.Options;
using MenuBuilder.Interfaces;

namespace MenuBuilder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCitizenOption printCitizen = new PrintCitizenOption();
            Option1 option1 = new Option1();
            ExitOption existOption = new ExitOption();
            Validation validation = new Validation();
            ConsoleSystem consoleSystem = new ConsoleSystem();

            MenuBuilder<string> menuBuilderString = new MenuBuilder<string>(consoleSystem, validation);
            MenuBuilder<int> menuBuilderInt = new MenuBuilder<int>(consoleSystem, validation);

            var menu = menuBuilderString
              .AddOption(option1.OptionMessage, option1)
              .AddOption(existOption.OptionMessage, existOption)
              .Build();

            MenuOption<string> menuOption = new MenuOption<string>(menu, "new menu");

            var menu2 = menuBuilderInt
                .AddOption(1, menuOption)
                .AddOption(2, printCitizen)
                .AddOption(3, existOption)
                .Build();

            menu2.RunMenu();
        }
    }
}
