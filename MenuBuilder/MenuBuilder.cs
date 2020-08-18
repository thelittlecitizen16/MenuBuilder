using System;
using MenuBuilder.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
   public class MenuBuilder<T>
    {
        private Dictionary<T, IOption> _allOptions;
        private ISystem _system;
        private IValidation _validation;
        public MenuBuilder(ISystem system, IValidation validation)
        {
            _allOptions = new Dictionary<T, IOption>();
            _system = system;
            _validation = validation;
        }

        public MenuBuilder<T> AddOption(T key, IOption option)
        {
            if (!_allOptions.ContainsKey(key))
            {
                _allOptions.Add(key, option);
            }

            return this;
        }

        public Menu<T> Build()
        {
            return new Menu<T>(_allOptions, _system, _validation);
        }
    }
}
