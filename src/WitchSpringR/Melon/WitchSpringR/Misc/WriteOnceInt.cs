namespace WitchSpringR.Misc;

public sealed class WriteOnceInt : MonoBehaviour
{
    private int _value;
    private bool _hasValue;

    public override string ToString()
    {
        return _hasValue ? _value.ToString(CultureInfo.InvariantCulture) : "";
    }

    public int Value
    {
        get => !_hasValue ? 0 : _value;
        set
        {
            if (_hasValue) return;
            _value = value;
            _hasValue = true;
        }
    }

    public static implicit operator int(WriteOnceInt value) 
    { 
        return value.Value; 
    }
}