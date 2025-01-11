using UnityEngine;

namespace DrovaForsakenKin.MonoBehaviours;

//MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceVector2 : MonoBehaviour
{
    private Vector2 _value;

    public WriteOnceVector2(Vector2 value)
    {
        Value = value;
    }

    public WriteOnceVector2()
    {
    }

    public override string ToString()
    {
        return HasValue ? _value.ToString() : "";
    }
    
    public bool HasValue { get; private set; }

    public Vector2 Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator Vector2(WriteOnceVector2 value) 
    { 
        return value.Value; 
    }
}