namespace TheHouseOfTheDead2Remake.Misc;

/// <summary>
/// Provides descriptions for various game configuration fields.
/// </summary>
public static class Descriptions
{
    /// <summary>
    /// Retrieves a best guess, user-friendly description for the specified field name.
    /// </summary>
    /// <param name="fieldName">The name of the field to retrieve the description for.</param>
    /// <returns>The description of the field, or a default message if not found.</returns>
    internal static string GetDescription(string fieldName)
    {
        var descriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "GAME_VERSION", "The current version of the game." },
            { "URP_VERSION", "The version of the Unity Render Pipeline being used." },
            { "SAVE_INDICATOR_DISPLAY_TIME", "The time, in seconds, to display the save indicator." },
            { "IS_JAPANESE_VERSION", "Indicates if the game is the Japanese version." },
            { "LOAD_LEVEL_SELECTION", "Enables or disables the level selection on load." },
            { "CAN_PAUSE_IN_CUTSCENE", "Allows pausing the game during cutscenes." },
            { "USE_CAMERA_SMOOTHING", "Smooths camera movement during gameplay." },
            { "USE_HEAD_BOBBING", "Enables or disables head bobbing during movement." },
            { "FOCUS_ON_SHOT_ENEMY", "Focuses the camera on enemies when they are shot." },
            { "PLAYER_ONE_NAME", "The name of player one." },
            { "PLAYER_TWO_NAME", "The name of player two." },
            { "FIRST_PLAYER_COLOR", "The color assigned to player one." },
            { "SECOND_PLAYER_COLOR", "The color assigned to player two." },
            { "DISPLAY_BLOODSPLASH_EFFECT", "Enables or disables the blood splash effect." },
            { "USE_SPHERE_CAST", "Enables the use of sphere casting for hit detection." },
            { "CONST_SPHERECAST_SIZE", "The constant size of the sphere used for casting." },
            { "USE_WEAPON_RECOIL", "Enables or disables weapon recoil effects." },
            { "FRAMES_WITHOUT_HANDLING_INPUTS_AFTER_PLAYER_DEATH", "The number of frames where inputs are ignored after player death." },
            { "JOYSTICK_SENSITIVITY_COMPENSATION", "Adjusts joystick sensitivity compensation." },
            { "MOTION_BLUR_INTENSITY", "The intensity of the motion blur effect." },
            { "CLAMP_SCORE_TO_ZERO_IN_CLASSIC", "Clamps the score to zero in classic mode." },
            { "CLAMP_SCORE_TO_ZERO_IN_MODERN", "Clamps the score to zero in modern mode." },
            { "BEST_ENDING_SCORE_REQUIREMENT", "The score required to achieve the best ending." },
            { "CAN_PLAYER_SPEND_SCORE_TO_BUY_TOKENS", "Allows players to spend score to purchase tokens." },
            { "CONTINUATION_TOKEN_COST", "The cost of a continuation token." },
            { "CONTINUATION_TIMEOUT", "The time limit for continuing after a game over." },
            { "DEFAULT_LIFES", "The default number of lives per player." },
            { "MAX_NUMBER_OF_LIFES", "The maximum number of lives a player can have." },
            { "FIGHT_CAMERA_FOCUS_OFFSET_MULTIPLIER", "Multiplier for camera focus offset during fights." },
            { "MULTIPLAYER_HEALTH_MULTIPLIER", "Multiplier for player health in multiplayer mode." },
            { "CROSSBOW_DAMAGE_MULTIPLAYER_FOR_ENEMIES", "Damage multiplier for enemies hit by the crossbow." },
            { "CROSSBOW_DAMAGE_MULTIPLAYER_FOR_BOSS", "Damage multiplier for bosses hit by the crossbow." },
            { "USE_ENEMY_MOVEMENT_SMOOTHING", "Enables smoothing of enemy movement." },
            { "INCOMING_PROJECTILE_FOCUS_MODE", "Focus mode when a projectile is incoming." },
            { "FULL_DESTRO_LIMB_EXPLOSION_RADIUS", "The radius of the explosion when a limb is fully destroyed." },
            { "LIMB_EXPLOSION_FORCE_MULTIPLIER_WHEN_FULL_DESTRO", "Force multiplier for explosions during full limb destruction." },
            { "ENEMY_RESUME_DELAY_AFTER_PLAYER_REVIVE", "Delay before enemies resume activity after a player revive." },
            { "ENEMY_RESUME_WAIT_AFTER_PLAYER_REVIVE", "Wait time before enemies resume activity after a player revive." },
            { "AUTO_RELOAD_DELAY", "Delay before auto-reloading begins." },
            { "HORDE_ATTACK_GROUP_COUNT", "The number of enemies in a horde attack group." },
            { "CAN_KILL_SCIENTISTS", "Allows killing scientists during gameplay." },
            { "CAN_STAKEGUN_NAIL_SCIENTIST", "Allows scientists to be pinned with the stake gun." },
            { "SPAWN_LESS_LIMBS", "Reduces the number of spawned limbs after destruction." },
            { "DAMAGED_BODY_PART_TINT_COLOR", "The tint color applied to damaged body parts." },
            { "BLOOD_COLOR", "The color of blood effects." },
            { "ACHIEVEMENT_BUTCHER_THRESHOLD", "Threshold for unlocking the Butcher achievement." },
            { "ACHIEVEMENT_HEADHUNTER_THRESHOLD", "Threshold for unlocking the Headhunter achievement." },
            { "ACHIEVEMENT_GRANADIER_KILL_COUNT", "Kill count needed for the Grenadier achievement." },
            { "ACHIEVEMENT_SADIST_MIN_PART_COUNT", "Minimum body part count for the Sadist achievement." },
            { "ACHIEVEMENT_SWIFTY_THRESHOLD", "Threshold for the Swifty achievement." },
            { "ACHIEVEMENT_RINGO_THRESHOLD", "Threshold for the Ringo achievement." },
            { "ACHIEVEMENT_TRIPLEKILL_KILL_COUNT", "Kill count for the Triple Kill achievement." },
            { "ACHIEVEMENT_PENTAKILL_KILL_COUNT", "Kill count for the Penta Kill achievement." },
            { "ACHIEVEMENT_ENDING_THRESHOLD", "Score threshold for an achievement ending." },
            { "NUMBER_OF_RESULTS_STORED_IN_LEADERBOARD", "The number of results stored in the leaderboard." },
            { "MAX_LENGTH_OF_PLAYER_NAME", "The maximum allowed length for a player name." },
            { "ALL_CHEATS_ENABLED", "Enables all cheat codes." },
            { "ARE_DEVELOPMENT_CHEATS_ENABLED", "Enables developer-specific cheat codes." },
            { "DISABLE_DEBUG_SHORTCUTS", "Disables debug shortcuts in the game." },
            { "DISPLAY_POINTS_ON_CROSSROADS", "Displays points when players reach crossroads." },
            { "PAGE_DISPLAY_TIME", "The display time for each page during transitions." }
        };

        return descriptions.TryGetValue(fieldName, out var description)
            ? description
            : "No description available.";
    }
}