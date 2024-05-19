namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class SpriteExpander : MonoBehaviour
{
    /// <summary>
    /// Expands a sprite horizontally by instantiating new sprites based on the original sprite's width.
    /// </summary>
    /// <param name="parentGameObject">The parent GameObject where the sprite to be expanded is located.</param>
    /// <param name="spriteName">The name of the sprite GameObject to be expanded.</param>
    /// <param name="expansionCount">The number of times the sprite should be expanded.</param>
    /// <param name="expandToLeft">Determines the direction of expansion. True for left, false for right.</param>
    public static void ExpandSpriteHorizontally(GameObject parentGameObject, string spriteName, int expansionCount, bool expandToLeft)
    {
        var spriteTransform = parentGameObject.transform.FindFirstChildByName(spriteName);
        if (spriteTransform)
        {
            Plugin.LOG.LogWarning($"Sprite: {spriteTransform.name} - {spriteTransform.gameObject.GetGameObjectPath()}");
            var originalSprite = spriteTransform.gameObject;
            var spriteRenderer = originalSprite.GetComponent<SpriteRenderer>();
            if (spriteRenderer)
            {
                var spriteWidth = spriteRenderer.bounds.size.x;
                for (var i = 0; i < expansionCount; i++)
                {
                    var newSprite = Instantiate(originalSprite, originalSprite.transform.parent);
                    var newPosition = newSprite.transform.localPosition;
                 
                    newPosition.x += spriteWidth * (expandToLeft ? -(i + 1) : (i + 1));
                    newSprite.transform.localPosition = newPosition;
                }
            }
        }
    }
}