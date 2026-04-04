namespace SeaOfStars.Utilities;

public sealed class WriteOnceFloat
{
    private float _value;

    public override string ToString()
    {
        return HasValue ? _value.ToString() : "";
    }

    public bool HasValue { get; private set; }

    public float Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator float(WriteOnceFloat writeOnce)
    {
        return writeOnce.Value;
    }
}
