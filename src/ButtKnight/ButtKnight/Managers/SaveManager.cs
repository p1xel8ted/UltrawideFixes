namespace ButtKnight.Managers;

internal static class SaveManager
{
    private static bool _showConfirmationDialog;

    internal static void RegisterDeleteSaveConfig(ConfigFile config)
    {
        config.Bind("07. NUCLEAR", "RESET PROGRESS", false, new ConfigDescription(
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
        var basePath = Application.persistentDataPath;
        var saveBasePath = Path.Combine(basePath, "NaninovelData", "Saves");

        var results = new System.Text.StringBuilder();
        results.AppendLine("Progress Reset Results:");
        results.AppendLine();

        var storageCount = DeleteFilesInDirectory(Path.Combine(basePath, "Storage"), "*.txt");
        results.AppendLine($"• Storage files: {storageCount} deleted");

        var settingsDeleted = DeleteFile(Path.Combine(saveBasePath, "Settings.json"));
        results.AppendLine($"• Settings.json: {(settingsDeleted ? "Deleted" : "Not found")}");

        var globalSaveDeleted = DeleteFile(Path.Combine(saveBasePath, "GlobalSave.nson"));
        results.AppendLine($"• GlobalSave.nson: {(globalSaveDeleted ? "Deleted" : "Not found")}");

        ShowPopup(results.ToString());
    }

    private static int DeleteFilesInDirectory(string directoryPath, string searchPattern)
    {
        if (!Directory.Exists(directoryPath))
        {
            Plugin.Log.LogInfo($"{Path.GetFileName(directoryPath)} folder not found.");
            return 0;
        }

        var files = Directory.GetFiles(directoryPath, searchPattern);
        var deletedCount = files.Count(TryDeleteFile);

        Plugin.Log.LogInfo(deletedCount > 0
            ? $"Deleted {deletedCount} file(s) from {Path.GetFileName(directoryPath)}."
            : $"No files matching '{searchPattern}' found in {Path.GetFileName(directoryPath)}.");

        return deletedCount;
    }

    private static bool DeleteFile(string filePath)
    {
        var fileName = Path.GetFileName(filePath);

        if (!File.Exists(filePath))
        {
            Plugin.Log.LogInfo($"{fileName} not found.");
            return false;
        }

        if (TryDeleteFile(filePath))
        {
            Plugin.Log.LogInfo($"Deleted {fileName}.");
            return true;
        }

        Plugin.Log.LogError($"Failed to delete {fileName}.");
        return false;
    }

    private static bool TryDeleteFile(string filePath)
    {
        try
        {
            File.Delete(filePath);
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"Exception deleting {Path.GetFileName(filePath)}: {ex.Message}");
            return false;
        }
    }
    
    private static void ShowPopup(string message)
    {
        if (Plugin.PopupManagerInstance != null)
        {
            Plugin.PopupManagerInstance.ShowPopupDlg(message, "save_deletion_result", false);
        }
        else
        {
            Plugin.Log.LogWarning("PopupManager not available. Results:\n" + message);
        }
    }
}
