namespace RoguePrinceOfPersia;

public sealed class WriteOnceVector3 : MonoBehaviour
{
    private Vector3 _value;
    private bool _hasValue;

    // Constructor to initialize with a value
    public WriteOnceVector3(Vector3 value)
    {
        Value = value;
    }

    // Default constructor
    public WriteOnceVector3()
    {
    }

    // ToString override to handle conversion to string
    public override string ToString()
    {
        // Handle culture-specific formatting if needed
        return _hasValue ? _value.ToString() : "";
    }

    // Property to get or set the value, ensuring it's only set once
    public Vector3 Value
    {
        get => !_hasValue ? default : _value;
        set
        {
            if (_hasValue) return;
            _value = value;
            _hasValue = true;
        }
    }

    // Implicit operator to allow easy conversion from WriteOnceFloat to float
    public static implicit operator Vector3(WriteOnceVector3 value)
    {
        return value.Value;
    }
}