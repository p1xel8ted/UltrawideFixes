namespace CrowCountry.Generics;

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
    
    // ReSharper disable once MemberCanBePrivate.Global
    public bool HasValue { get; private set; }

    public static implicit operator T(WriteOnce<T> value) { return value.Value; }
}