namespace ButtKnight.Managers;

internal static class SaveManager
{
    private static bool _showConfirmationDialog;

    internal static void RegisterDeleteSaveConfig(ConfigFile config)
    {
        config.Bind("08. NUCLEAR", "RESET PROGRESS", false, new ConfigDescription(
            "WARNING: This will delete all your progress.",
            null,
            new ConfigurationManagerAttributes { Order = 0, CustomDrawer = DeleteSaveDrawer }));
    }

    private static void DeleteSaveDrawer(ConfigEntryBase entry)
    {
        if (_showConfirmationDialog)
        {
            DisplayConfirmationDialog();
        }
        else
        {
            var button = GUILayout.Button("Delete Progress", GUILayout.ExpandWidth(true));
            if (button)
            {
                _showConfirmationDialog = true;
            }
        }
    }

    private static void DisplayConfirmationDialog()
    {
        GUILayout.Label("Are you sure you want to reset progress?");

        GUILayout.BeginHorizontal();
        {
            if (GUILayout.Button("Yes", GUILayout.ExpandWidth(true)))
            {
                DeleteSave();
                _showConfirmationDialog = false;
            }

            if (GUILayout.Button("No", GUILayout.ExpandWidth(true)))
            {
                _showConfirmationDialog = false;
            }
        }
        GUILayout.EndHorizontal();
    }

    private static void DeleteSave()
    {
        
        MonoSingleton<GameManager>.Instance.ResetData();
        ShowPopup("All progress has been reset.");
    }

   
    
    private static void ShowPopup(string message)
    {
        if (Plugin.PopupManagerInstance)
        {
            Plugin.PopupManagerInstance.ShowPopupDlg(message, "save_deletion_result", false);
        }
        else
        {
            Plugin.Log.LogWarning("PopupManager not available. Results:\n" + message);
        }
    }
}
