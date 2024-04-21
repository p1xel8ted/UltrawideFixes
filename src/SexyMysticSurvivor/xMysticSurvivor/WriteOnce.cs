using System;

namespace xMysticSurvivor;

public sealed class WriteOnce<T>
{
    private T? _value;
    private bool _hasValue;
    public override string ToString()
    {
        return _hasValue ? Convert.ToString(_value) : "";
    }
    public T? Value
    {
        get => !_hasValue ? default : _value;
        set
        {
            if (_hasValue) return;
            _value = value;
            _hasValue = true;
        }
    }

    public static implicit operator T?(WriteOnce<T?> value) { return value.Value; }
}