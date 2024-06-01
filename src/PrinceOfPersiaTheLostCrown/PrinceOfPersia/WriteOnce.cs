// namespace PrinceOfPersia;
//
// public sealed class WriteOnce : MonoBehaviour
// {
//     private Vector2 _value;
//     private bool _hasValue;
//
//     // public WriteOnce(Vector2 value)
//     // {
//     //     Value = value;
//     // }
//     //
//     // public WriteOnce()
//     // {
//     // }
//
//     public override string ToString()
//     {
//         return _hasValue ? _value.ToString() : "";
//     }
//
//     public Vector2 Value
//     {
//         get => !_hasValue ? default : _value;
//         set
//         {
//             if (_hasValue) return;
//             _value = value;
//             _hasValue = true;
//         }
//     }
//
//     public static implicit operator Vector2(WriteOnce value) 
//     { 
//         return value.Value; 
//     }
// }