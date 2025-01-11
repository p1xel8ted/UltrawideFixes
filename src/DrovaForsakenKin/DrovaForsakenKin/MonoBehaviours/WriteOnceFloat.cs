using System.Globalization;
using UnityEngine;

namespace DrovaForsakenKin.MonoBehaviours;

//MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceFloat : MonoBehaviour
{
    private float _value;

    public WriteOnceFloat(float value)
    {
        Value = value;
    }

    public WriteOnceFloat()
    {
    }

    public override string ToString()
    {
        return HasValue ? _value.ToString(CultureInfo.InvariantCulture) : "";
    }
    
    public bool HasValue { get; private set; }

    public float Value
    {
        get => !HasValue ? 0 : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator float(WriteOnceFloat value) 
    { 
        return value.Value; 
    }
}