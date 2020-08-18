using System;
using System.Collections.Generic;
using MenuBuilder.Interfaces;
using System.Text;

namespace MenuBuilder
{
    public  class MenuCreator<T>
    {
        private MenuBuilder<T> _menuBuilder;
        public MenuCreator(ISystem system, IValidation<T> validation)
        {
            _menuBuilder = new MenuBuilder<T>(system, validation);
        }
        public  Menu<T> CreateMenu(List<Tuple<T, IOption>> allOptions)
        {
            foreach (var option in allOptions)
            {
                _menuBuilder.AddOption(option.Item1, option.Item2);
            }

            return _menuBuilder.Build();
        }
    }
}
