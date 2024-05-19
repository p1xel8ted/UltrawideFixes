namespace AlexKiddMiracleWorldDX.LevelFixes;

public static class Level_5
{
    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.level_5, StringComparison.OrdinalIgnoreCase);

    internal static void RunFixes()
    {
        if (!CorrectScene) return;
        
        var tileMap = GameObject.Find("Tilemap");
        if (tileMap)
        {
            //this expands the grass sprite to the left on modern level 5, and duplicates the entire floor to replace the one underneath
            SpriteExpander.ExpandSpriteHorizontally(tileMap, "TallGrassEffect", 20, true);
            var floor = tileMap.transform.Find("Floor");
            if (floor)
            {
                var newFloor = Object.Instantiate(floor, floor.parent);
                floor.name = "FloorTop";
                newFloor.name = "FloorBottom";
                newFloor.position = newFloor.position with {y = -0.5f};
                newFloor.SetSiblingIndex(4);
            }
        }
    }
}