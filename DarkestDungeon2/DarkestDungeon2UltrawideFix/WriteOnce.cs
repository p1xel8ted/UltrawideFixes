namespace DarkestDungeon2UltrawideFix;

public sealed class WriteOnce<T>
{
    private T? _value;

    public bool HasValue { get; private set; }
    
    public T? Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator T?(WriteOnce<T?> value) { return value.Value; }

    public void ResetValue()
    {
        HasValue = false;
        _value = default;
    }
}