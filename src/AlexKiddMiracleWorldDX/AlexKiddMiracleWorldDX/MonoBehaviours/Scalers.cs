namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class Scalers : MonoBehaviour
{
    internal static void AddPositiveScaler(GameObject parentGameObject, string target = "", Vector2 buffers = default, bool updateEnabled = true, bool forceYScale = false)
    {
        // Determine the target GameObject: either the parentGameObject itself or a child specified by the target string.
        var targetGameObject = string.IsNullOrEmpty(target) ? parentGameObject : parentGameObject.transform.FindFirstChildByName(target)?.gameObject;

        if (targetGameObject)
        {
            Plugin.LOG.LogInfo($"Adding PositiveScaler to {targetGameObject.name} - {targetGameObject.GetGameObjectPath()}");
            // Add the PositiveScaler component to the target GameObject and set its buffers.
            var scaler = targetGameObject.TryAddComponent<PositiveScaler>();
            if (scaler) // Ensure the scaler is successfully added before attempting to set buffers.
            {
                scaler.SetBuffers(buffers.x, buffers.y);
                scaler.UpdateEnabled = updateEnabled;
                scaler.ForceYScaling = forceYScale;
            }
        }
    }
    
    internal static void AddNegativeScaler(GameObject parentGameObject, string target = "", Vector2 buffers = default, bool updateEnabled = true)
    {
        // Determine the target GameObject: either the parentGameObject itself or a child specified by the target string.
        var targetGameObject = string.IsNullOrEmpty(target) ? parentGameObject : parentGameObject.transform.FindFirstChildByName(target)?.gameObject;

        if (targetGameObject)
        {
            // Add the PositiveScaler component to the target GameObject and set its buffers.
            var scaler = targetGameObject.TryAddComponent<NegativeScaler>();
            if (scaler) // Ensure the scaler is successfully added before attempting to set buffers.
            {
                scaler.UpdateEnabled = updateEnabled;
            }
        }
    }


    internal static void AddHudMover(GameObject parentGameObject, string target = "")
    {
        if (string.IsNullOrEmpty(target) || parentGameObject.name.Equals(target))
        {
            parentGameObject.TryAddComponent<HudMover>();
        }
    }
    internal static void AddHudScaler(GameObject parentGameObject, string target = "", bool updateEnabled = true)
    {
        // Add the HudScaler component if the target is empty (default case) 
        // or if the parentGameObject's name matches the target.
        if (string.IsNullOrEmpty(target) || parentGameObject.name.Equals(target))
        {
            var scaler = parentGameObject.TryAddComponent<HudScaler>();
            if (scaler)
            {
                scaler.UpdateEnabled = updateEnabled;
            }
        }
    }

}