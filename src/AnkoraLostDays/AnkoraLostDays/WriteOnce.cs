namespace AnkoraLostDays;

public sealed class WriteOnce<T> : MonoBehaviour where T : struct
{
    private T _value;
    private bool _hasValue;

    // Constructor to initialize with a value
    public WriteOnce(T value)
    {
        Value = value;
    }

    // Default constructor
    public WriteOnce()
    {
    }

    // ToString override to handle conversion to string
    public override string ToString()
    {
        // If T is a numeric type, handle culture-specific formatting
        return _hasValue ? _value.ToString() : "";
    }

    // Property to get or set the value, ensuring it's only set once
    public T Value
    {
        get => !_hasValue ? default : _value;
        set
        {
            if (_hasValue) return;
            _value = value;
            _hasValue = true;
        }
    }

    // Implicit operator to allow easy conversion from WriteOnce<T> to T
    public static implicit operator T(WriteOnce<T> value)
    {
        return value.Value;
    }
}