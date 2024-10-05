namespace Mouthwashing;

public sealed class WriteOnce<T>
{
    private T _value;

    private bool HasValue { get; set; }
    
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

    public static implicit operator T(WriteOnce<T> value) { return value.Value; }

    public void ResetValue()
    {
        HasValue = false;
        _value = default;
    }
}