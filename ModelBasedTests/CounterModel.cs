using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBasedTests
{
    public class CounterModel
    {
        public int Value { get; private set; }

        public CounterModel(int initialValue = 0)
        {
            Value = initialValue;
        }

        public void Increment()
        {
            Value++;
        }

        public void Decrement()
        {
            if (Value > 0)
            {
                Value--;
            }
            else
            {
                throw new InvalidOperationException("Counter cannot be decremented below zero.");
            }
        }

        public void Reset()
        {
            Value = 0;
        }

        public override string ToString() => Value.ToString();
        
    }

}
