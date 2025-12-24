namespace ArkhamHorrorMothersEmbrace.Utils;

public sealed class WriteOnce<T>
{
    private T _value;

    public override string ToString()
    {
        return HasValue ? _value?.ToString() ?? "" : "";
    }

    public bool HasValue { get; private set; }

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

    public static implicit operator T(WriteOnce<T> writeOnce)
    {
        return writeOnce.Value;
    }
}