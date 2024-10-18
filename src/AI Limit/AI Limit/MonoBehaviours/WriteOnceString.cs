namespace AI_Limit.MonoBehaviours;

// MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceString : MonoBehaviour
{
    private string _value;
    private bool _hasValue;

    // Constructor that sets the initial value
    public WriteOnceString(string value)
    {
        Value = value;
    }

    // Default constructor
    public WriteOnceString() { }

    // Override ToString to return the string value if set, otherwise empty
    public override string ToString()
    {
        return _hasValue ? _value : "";
    }
    
    // Property to get or set the value, but only allow setting once
    public string Value
    {
        get => !_hasValue ? default : _value;
        set
        {
            if (_hasValue) return;  // Prevent further modification
            _value = value;
            _hasValue = true;
        }
    }

    // Implicit conversion operator to convert WriteOnceString to string
    public static implicit operator string(WriteOnceString value)
    {
        return value.Value;
    }
}