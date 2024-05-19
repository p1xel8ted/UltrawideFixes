namespace AlexKiddMiracleWorldDX.LevelFixes;

public static class Level_7_Extra
{
    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.level_7_extra, StringComparison.OrdinalIgnoreCase);

    internal static void RunFixes()
    {
        if (!CorrectScene) return;
        FixLights();
        FixLava();
    }
    private static void FixLights()
    {
        var lights = GameObject.Find("Lights");
        if (lights)
        {
            Scalers.AddPositiveScaler(lights, buffers: new Vector2(0f, 0f), updateEnabled: false);
        }

        var background = Resources.FindObjectsOfTypeAll<SpriteRenderer>().First(a => a.name.Equals("level_7_extra_fondo", StringComparison.Ordinal));
        if (background)
        {
            Scalers.AddPositiveScaler(background.gameObject, buffers: new Vector2(0f, 0f), updateEnabled: false);
        }
    }

    private static void FixLava()
    {
        var lavaGameObject = GameObject.Find("LavaRemake");
        if (lavaGameObject)
        {
            var lava = lavaGameObject.transform;

            var top = lava.transform.GetChild(24);

            var newLava = Object.Instantiate(lava, lava.parent);
            newLava.name = "LavaFix!";

            var newTop = Object.Instantiate(top, newLava);
            newTop.name = "TopFix!";

            
            //fill the gaps in the lava due to the extending the screen
            SpriteExpander.ExpandSpriteHorizontally(newLava.gameObject, "TopFix!", 20, true);

            //remove the original lava
            var components = newLava.GetComponentsInChildren<Transform>();
            foreach (var comp in components.ToList().Where(comp => comp.name.StartsWith("BackgroundLava")))
            {
                Object.DestroyImmediate(comp.gameObject, true);
            }

            //disable the first 8 as it renders on top of the ground (instead of behind)
            for (var i = 0; i < 7; i++)
            {
                newLava.GetChild(i).gameObject.SetActive(false);
            }
            
            //create two new copies of both the entire original row of lava and the new lava
            var bottomLava = Object.Instantiate(newLava.gameObject, newLava.parent);
            var topLava = Object.Instantiate(lavaGameObject, lavaGameObject.transform.parent);
            
            topLava.name = "TopLava";
            bottomLava.name = "BottomLava";
            
            //move the lava down to cover the gaps
            topLava.transform.position = topLava.transform.position with {y = -3.285f};
            bottomLava.transform.position = bottomLava.transform.position with {y = -3.285f};
            
            //disable the lava bubbling pops animation
            foreach(var animator in topLava.GetComponentsInChildren<Animator>())
            {
                animator.enabled = false;
            }
            
            foreach(var animator in bottomLava.GetComponentsInChildren<Animator>())
            {
                animator.enabled = false;
            }
            
        }
    }
}