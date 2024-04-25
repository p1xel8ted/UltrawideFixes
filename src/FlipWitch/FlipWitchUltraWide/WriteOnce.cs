namespace FlipWitchUltraWide;

public sealed class WriteOnce<T>
{
    private T _value;
    public override string ToString()
    {
        return HasValue ? Convert.ToString(_value) : "";
    }

    public T Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    private bool HasValue { get; set; }

    public static implicit operator T(WriteOnce<T> value)
    {
        return value.Value;
    }
}