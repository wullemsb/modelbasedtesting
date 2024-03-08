using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBasedTests
{
    public class Counter
    {
        private int _currentValue;

        public int CurrentValue { get => _currentValue; }

        public Counter(int initialValue = 0)
        {
            _currentValue = initialValue;
        }

        public int Increment()
        {
            //We introduced a bug on purpose
            //if (_currentValue <= 3)
            //{
            //    _currentValue += 1;
            //}
            //else
            //{
            //    _currentValue += 2;
            //}
            _currentValue+=1;
            return _currentValue;
        }

        public int Decrement()
        {
            _currentValue  -= 1;
            return _currentValue;
        }

        public void Reset()
        {
            _currentValue = 0;
        }

        public override string ToString()
        {
            return $"Counter = {CurrentValue}";
        }
    }
}
