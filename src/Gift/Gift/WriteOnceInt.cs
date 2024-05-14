using System;
using UnityEngine;

namespace Gift
{
    public sealed class WriteOnceInt : MonoBehaviour
    {
        private int _value;
        public override string ToString()
        {
            return HasValue ? Convert.ToString(_value) : "";
        }
        public int Value
        {
            get => !HasValue ? default : _value;
            set
            {
                if (HasValue) return;
                _value = value;
                HasValue = true;
            }
        }
        
        public bool HasValue { get; private set; }

        public static implicit operator int(WriteOnceInt value) { return value.Value; }
    }
}