namespace Kingsgrave;

//MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceFloat : MonoBehaviour
{
    private float _value;
    private bool _hasValue;

    public WriteOnceFloat(float value)
    {
        Value = value;
    }

    public WriteOnceFloat()
    {
    }

    public override string ToString()
    {
        return _hasValue ? _value.ToString(CultureInfo.InvariantCulture) : "";
    }

    public float Value
    {
        get => !_hasValue ? default : _value;
        set
        {
            if (_hasValue) return;
            _value = value;
            _hasValue = true;
        }
    }

    public static implicit operator float(WriteOnceFloat value) 
    { 
        return value.Value; 
    }
}