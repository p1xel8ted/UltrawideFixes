namespace TheHouseOfTheDead2Remake.Misc;

/// <summary>
/// A generic class that allows a value to be written only once.
/// </summary>
public sealed class WriteOnce<T>
{
    private T _value; // Holds the value of the instance

    /// <summary>
    /// Constructor to initialize the instance with a value.
    /// </summary>
    /// <param name="value">The value to initialize with.</param>
    public WriteOnce(T value)
    {
        Value = value;
    }

    /// <summary>
    /// Default constructor for creating an uninitialized instance.
    /// </summary>
    public WriteOnce()
    {
    }

    /// <summary>
    /// Overrides ToString to return the string representation of the value.
    /// </summary>
    /// <returns>The string representation of the value, or an empty string if not set.</returns>
    public override string ToString()
    {
        // Handle culture-specific formatting if necessary
        return HasValue ? _value?.ToString() ?? "" : "";
    }

    /// <summary>
    /// Resets the value, allowing it to be set again.
    /// </summary>
    public void ResetValue()
    {
        HasValue = false;
    }

    /// <summary>
    /// Gets or sets the value. Can only be set once unless reset.
    /// </summary>
    public T Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return; // Prevent multiple assignments
            _value = value;
            HasValue = true;
        }
    }

    public bool HasValue { get; private set; }

    /// <summary>
    /// Implicitly converts a WriteOnce<T> instance to its value.
    /// </summary>
    /// <param name="value">The WriteOnce<T> instance to convert.</param>
    public static implicit operator T(WriteOnce<T> value)
    {
        return value.Value;
    }
}