using UnityEngine;

namespace KazeWildMasks;

[Harmony]
public class LoadingScreenScaler : MonoBehaviour
{
    private Animator _animator;
    private Transform kaze;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        kaze = transform.FindChild("KazeLoadingIcon");
        
    }
    
    private void LateUpdate()
    {
        if (_animator)
        {
            _animator.transform.localScale = _animator.transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
        }
        if (kaze)
        {
            kaze.transform.localScale = kaze.transform.localScale with {x = Plugin.NegativeScaleFactor, y = Plugin.NegativeScaleFactor};
        }
    }
    
}