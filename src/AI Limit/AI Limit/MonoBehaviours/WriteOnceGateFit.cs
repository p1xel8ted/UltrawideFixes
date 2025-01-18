namespace AI_Limit.MonoBehaviours;

//MonoBehaviour is only here to satisfy IL2CPP injection
public sealed class WriteOnceGateFit : MonoBehaviour
{
    private Camera.GateFitMode _value;

    public WriteOnceGateFit(Camera.GateFitMode value)
    {
        Value = value;
    }

    public WriteOnceGateFit()
    {
    }

    public override string ToString()
    {
        return HasValue ? _value.ToString() : "";
    }
    
    public bool HasValue { get; private set; }

    public Camera.GateFitMode Value
    {
        get => !HasValue ? default : _value;
        set
        {
            if (HasValue) return;
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator Camera.GateFitMode(WriteOnceGateFit value) 
    { 
        return value.Value; 
    }
}