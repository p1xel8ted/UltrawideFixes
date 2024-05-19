namespace AlexKiddMiracleWorldDX.LevelFixes;


public static class Shop
{
    private static bool CorrectScene => SceneManager.GetActiveScene().name.Equals(Levels.shop, StringComparison.OrdinalIgnoreCase);
    public static void RunFixes()
    {
        //todo: shop
    }
    
}