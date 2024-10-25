using System.Globalization;

namespace CrowCountry.MonoBehaviours;

//MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceVector3 : MonoBehaviour
{
    private Vector3 _value;

    public WriteOnceVector3(Vector3 value)
    {
        Value = value;
    }

    public WriteOnceVector3()
    {
    }

    public override string ToString()
    {
        return HasValue ? _value.ToString() : "";
    }

    public bool HasValue { get; private set; }

    public Vector3 Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator Vector3(WriteOnceVector3 value)
    {
        return value.Value;
    }
}