using System;
using MenuBuilder.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
   internal class MenuBuilder<T>
    {
        private Dictionary<T, IOption> _allOptions;
        private ISystem _system;
        private IValidation<T> _validation;
        public MenuBuilder(ISystem system, IValidation<T> validation)
        {
            _allOptions = new Dictionary<T, IOption>();
            _system = system;
            _validation = validation;
        }

        public void AddOption(T key, IOption option)
        {
            _allOptions.Add(key, option);
        }

        public Menu<T> Build()
        {
            return new Menu<T>(_allOptions, _system, _validation);
        }
    }
}
