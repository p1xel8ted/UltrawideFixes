namespace AlexKiddMiracleWorldDX.LevelFixes;

public static class Level_7
{
    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.level_7, StringComparison.OrdinalIgnoreCase);

    internal static void RunFixes()
    {
        if (!CorrectScene) return;

        var acidGameObject = GameObject.Find("Tilemap/Barro");
        if (acidGameObject)
        {
            var acid = acidGameObject.transform;
            
            var top = acid.transform.GetChild(23); //this gets the top half of the lava tile
            var bottom = acid.transform.GetChild(11); //this gets the bottom half of the lava tile
            var newAcid = Object.Instantiate(acid, acid.parent);

            foreach (Transform child in newAcid)
            {
                Object.DestroyImmediate(child.gameObject,true);
            }

            Object.Instantiate(bottom, newAcid);
            Object.Instantiate(top, newAcid);

            SpriteExpander.ExpandSpriteHorizontally(newAcid.gameObject, "BackgroundBarroBot(Clone)", 20, true);
            SpriteExpander.ExpandSpriteHorizontally(newAcid.gameObject, "BackgroundBarro(Clone)", 20, true);

            newAcid.position = newAcid.position with {x = -34f};
        }
    }
}