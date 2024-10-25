using System.Globalization;

namespace CrowCountry.MonoBehaviours;

//MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceInt : MonoBehaviour
{
    private int _value;

    public WriteOnceInt(int value)
    {
        Value = value;
    }

    public WriteOnceInt()
    {
    }

    public override string ToString()
    {
        return HasValue ? _value.ToString(CultureInfo.InvariantCulture) : "";
    }

    public bool HasValue { get; private set; }

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

    public static implicit operator int(WriteOnceInt value)
    {
        return value.Value;
    }
}