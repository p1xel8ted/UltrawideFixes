using System.Globalization;

namespace Snufkin;

public sealed class WriteOnceFloat : MonoBehaviour
{
    private float _value;
    private bool _hasValue;

    // Constructor to initialize with a value
    public WriteOnceFloat(float value)
    {
        Value = value;
    }

    // Default constructor
    public WriteOnceFloat()
    {
    }

    // ToString override to handle conversion to string
    public override string ToString()
    {
        // Handle culture-specific formatting if needed
        return _hasValue ? _value.ToString(CultureInfo.InvariantCulture) : "";
    }

    // Property to get or set the value, ensuring it's only set once
    public float Value
    {
        get => !_hasValue ? 0 : _value;
        set
        {
            if (_hasValue) return;
            _value = value;
            _hasValue = true;
        }
    }

    // Implicit operator to allow easy conversion from WriteOnceFloat to float
    public static implicit operator float(WriteOnceFloat value)
    {
        return value.Value;
    }
}