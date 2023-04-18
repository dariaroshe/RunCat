using System;

namespace Service
{
    public class HealthField
    {
        private int _value;
        public event Action<int, int> Changed;

        public HealthField()
        {
        }

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                var oldValue = _value;
                _value = value;
                Changed?.Invoke(oldValue, _value);
            }
        }
    }
}