namespace HollowKnightSilkSong;

/// <summary>
/// A generic class that allows a value to be written only once.
/// Once set, the value cannot be changed unless explicitly reset.
/// </summary>
/// <remarks>
/// This class is designed for single-threaded use within Unity's main thread.
/// Setting the value multiple times will silently fail (by design) - only the first assignment takes effect.
/// Use ResetValue() to allow the value to be set again.
/// </remarks>
/// <typeparam name="T">The type of value to store</typeparam>
public sealed class WriteOnce<T>
{
    private T _value; // Holds the value of the instance

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
    /// <value>
    /// When getting: Returns the stored value if set, otherwise returns default(T).
    /// When setting: Only the first assignment succeeds; subsequent assignments are silently ignored.
    /// </value>
    public T Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return; // Silent failure by design - prevents multiple assignments
            _value = value;
            HasValue = true;
        }
    }

    /// <summary>
    /// Gets whether a value has been set.
    /// </summary>
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