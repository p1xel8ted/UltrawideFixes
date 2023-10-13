using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace PugMod
{
	public partial class ModSDKWindow
	{
		private class UpdateSDK
		{
			private readonly List<string> _pathsToCheck = new List<string>
			{
				@"A:\Steam\steamapps\common\Core Keeper",
				@"B:\Steam\steamapps\common\Core Keeper",
				@"C:\Program Files (x86)\Steam\steamapps\common\Core Keeper",
				@"D:\Steam\steamapps\common\Core Keeper",
				@"E:\Steam\steamapps\common\Core Keeper",
			};

			private DropdownField _gamePathDropDown;
			private Button _browseButton;
			private Button _updateButton;

			public void OnEnable(VisualElement root)
			{
				_gamePathDropDown = root.Q<DropdownField>("UpdateSDKChooseGamePath");
				_browseButton = root.Q<Button>("UpdateSDKChooseGamePathManually");
				_updateButton = root.Q<Button>("UpdateSDKUpdateButton");

				_gamePathDropDown.choices = new();

				foreach (var path in _pathsToCheck)
				{
					if ((_gamePathDropDown.choices == null || !_gamePathDropDown.choices.Contains(path))
						&& VerifyPath(path, true))
					{
						if (_gamePathDropDown.choices == null)
						{
							_gamePathDropDown.choices = new List<string>();
						}

						_gamePathDropDown.choices.Add(path);
					}
				}

				if (EditorPrefs.HasKey(GAME_INSTALL_PATH_KEY))
				{
					var chosenInstallPath = EditorPrefs.GetString(GAME_INSTALL_PATH_KEY);
					var chosenInstallPathIndex = _gamePathDropDown.choices.IndexOf(chosenInstallPath);
					if (chosenInstallPathIndex == -1)
					{
						chosenInstallPathIndex = _gamePathDropDown.choices.Count;
						_gamePathDropDown.choices.Add(chosenInstallPath);
					}

					_gamePathDropDown.index = chosenInstallPathIndex;
				}
				else if (_gamePathDropDown.choices?.Count > 0)
				{
					_gamePathDropDown.index = 0;
				}
				
				_gamePathDropDown.RegisterCallback<ChangeEvent<string>>(evt =>
				{
					if (string.IsNullOrEmpty(evt.newValue))
					{
						EditorPrefs.DeleteKey(GAME_INSTALL_PATH_KEY);
						return;
					}
					
					EditorPrefs.SetString(GAME_INSTALL_PATH_KEY, evt.newValue);
				});

				_browseButton.clicked += () => OpenFolderPanel();
				_updateButton.clicked += () =>
				{
#if PUG_MOD_SDK
					PugMod.ImporterWindow.UpdateFromGamePath(ImporterSettings.Instance, _gamePathDropDown.text, out _);
#else
					Debug.Log($"Should have updated SDK files from {_gamePathDropDown.text}, skipping since not SDK project");
#endif
				};
			}

			private void OpenFolderPanel()
			{
				string selectedPath = EditorUtility.OpenFolderPanel("Select Core Keeper install folder", "", "");
				if (!string.IsNullOrEmpty(selectedPath) && VerifyPath(selectedPath))
				{
					DirectoryInfo dirInfo = new DirectoryInfo(selectedPath);

					if (_gamePathDropDown.choices == null)
					{
						_gamePathDropDown.choices = new List<string>();
					}

					if (!_gamePathDropDown.choices.Contains(dirInfo.FullName))
					{
						_gamePathDropDown.choices.Add(dirInfo.FullName);
						_gamePathDropDown.choices.Sort();
					}

					_gamePathDropDown.index = _gamePathDropDown.choices.IndexOf(dirInfo.FullName);
				}
			}

			private bool VerifyPath(string path, bool silent = false)
			{
				if (!Directory.Exists(path))
				{
					if (!silent)
						Debug.Log($"{path} doesn't exist");
					return false;
				}

				if (!File.Exists(Path.Combine(path, "CoreKeeper.exe")))
				{
					if (Directory.Exists(Path.Combine(path, "Assets")))
					{
						// Path looks like Unity project, accept this for dev work
						return true;
					}
					if (!silent)
						ShowError("Chosen path does not contain the Core Keeper game.");
					return false;
				}

				return true;
			}
		}
	}
}