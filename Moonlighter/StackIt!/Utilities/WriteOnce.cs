namespace StackIt.Utilities;

/// <summary>
/// Represents a write-once storage for a value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the value to store.</typeparam>
public sealed class WriteOnce<T>
{
    private T _value;

    /// <summary>
    /// Gets a value indicating whether the <see cref="WriteOnce{T}"/> object has been assigned a value.
    /// </summary>
    public bool HasValue { get; private set; }
    
    /// <summary>
    /// Gets or sets the value stored in the <see cref="WriteOnce{T}"/> object. If the value has already been set, subsequent attempts to set the value will be ignored.
    /// </summary>
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

    /// <summary>
    /// Converts the value of the current <see cref="WriteOnce{T}"/> object to its equivalent underlying type.
    /// </summary>
    /// <param name="value">A <see cref="WriteOnce{T}"/> object.</param>
    public static implicit operator T(WriteOnce<T> value) { return value.Value; }

    /// <summary>
    /// Resets the value stored in the <see cref="WriteOnce{T}"/> object, allowing a new value to be set.
    /// </summary>
    public void ResetValue()
    {
        HasValue = false;
        _value = default;
    }
}