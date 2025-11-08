namespace xRESIST;

/// <summary>
/// A write-once float wrapper that only allows the value to be set once.
/// Useful for ensuring configuration values are not accidentally overwritten.
/// </summary>
public sealed class WriteOnceFloat
{
    private float _value;
    private bool _hasValue;
    private readonly object _lock = new();

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
        get
        {
            lock (_lock)
            {
                return !_hasValue ? 0 : _value;
            }
        }
        set
        {
            lock (_lock)
            {
                if (_hasValue) return;
                _value = value;
                _hasValue = true;
            }
        }
    }

    // Implicit operator to allow easy conversion from WriteOnceFloat to float
    public static implicit operator float(WriteOnceFloat value)
    {
        return value.Value;
    }
}