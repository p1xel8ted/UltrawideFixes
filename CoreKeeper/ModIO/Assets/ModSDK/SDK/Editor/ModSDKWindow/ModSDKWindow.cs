using ModIO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace PugMod
{
	public partial class ModSDKWindow : EditorWindow
	{
		private const string WINDOW_SHOWN_KEY = "PugMod/SDKWindow/Shown";
		
		private const string GAME_INSTALL_PATH_KEY = "PugMod/SDKWindow/GamePath";

		private const string CHOSEN_MOD_KEY = "PugMod/Window/UploadChosenMod";

		private const string LOGO_PATH = "Assets/ModSDK/Images";
		private const string DEFAULT_LOGO_PATH = "Assets/ModSDK/Images/DefaultLogo.png";

		private UpdateSDK _updateSDK = new UpdateSDK();
		private UploadMod _uploadMod = new UploadMod();
		private CreateMod _createMod = new CreateMod();

		// Define the views and buttons
		private VisualElement[] _views;
		private Button[] _buttons;

#if PUG_MOD_SDK
		[InitializeOnLoadMethod]
		private static void InitializeOnLoad()
		{
			if (IsNewSession())
			{
				EditorApplication.delayCall += OpenWindow;
			}
		}

		private static bool IsNewSession()
		{
			if (SessionState.GetBool(WINDOW_SHOWN_KEY, false))
			{
				return false;
			}

			SessionState.SetBool(WINDOW_SHOWN_KEY, true);
			return true;
		}
#endif
		
		[MenuItem("PugMod/Log out from mod.io")]
		public static void ClearAcceptedTerms()
		{
			if (!InitializeModIO())
			{
				return;
			}
			
			var result = ModIOUnity.LogOutCurrentUser();
			if (!result.Succeeded())
			{
				Debug.Log($"log out failed: {result.message} (code: {result.errorCode})");
			}
			
			ModIOUnity.Shutdown(null);
		}

		[MenuItem("PugMod/Open Mod SDK Window")]
		public static void OpenWindow()
		{
			AcceptTermsWindow.CheckIfTermsAccepted(termsAccepted =>
			{
				if (!termsAccepted)
				{
					ShowError("You will need to accept the terms to use the Mod SDK functions.");
					return;
				}
				
				ModSDKWindow wnd = GetWindow<ModSDKWindow>("Mod SDK");

				wnd.minSize = new Vector2(500, 400);
				// Want to set size without messing with position so doing it in a somewhat hacky way
				var oldMaxSize = wnd.maxSize;
				wnd.maxSize = new Vector2(500, 400);
				wnd.maxSize = oldMaxSize;
			});
		}

		public void CreateGUI()
		{
			if (!InitializeModIO())
			{
				Debug.LogError("failed to initialize mod.io");
				return;
			}
			
			// Each editor window contains a root VisualElement object
			VisualElement root = rootVisualElement;

			// Import UXML
			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/ModSDK/UI/ModSDKWindow.uxml");

			root.Add(uxml.CloneTree());

			// Define the views and buttons
			_views = new[]
			{
				root.Q<VisualElement>("StartView"),
				root.Q<VisualElement>("UpdateSDKView"),
				root.Q<VisualElement>("SearchModView"),
				root.Q<VisualElement>("UploadModView"),
				root.Q<VisualElement>("CreateModView"),
			};

			_buttons = new[]
			{
				root.Q<Button>("StartTabButton"),
				root.Q<Button>("UpdateSDKTabButton"),
				root.Q<Button>("SearchModTabButton"),
				root.Q<Button>("UploadModTabButton"),
				root.Q<Button>("CreateModTabButton"),
			};

			for (int i = 0; i < _buttons.Length; i++)
			{
				int index = i; // Local variable for closure
				_buttons[i].clicked += () => OnTabButtonClicked(index);
			}

			var logInButton = root.Q<Button>("LogInTabButton");
			logInButton.clicked += () => LogInModIO();

			_updateSDK.OnEnable(root);
			_uploadMod.OnEnable(root);
			_createMod.OnEnable(root);

			UpdateButtons(root, false);

			if (ModIOUnity.IsInitialized())
			{
				ModIOUnity.IsAuthenticated(result =>
				{
					if (!result.Succeeded())
					{
						Debug.Log("User not authenticated");
						return;
					}

					Debug.Log("User is authenticated");
					UpdateButtons(root, true);
				});
			}
		}

		private void OnDestroy()
		{
			if (ModIOUnity.IsInitialized())
			{
				ModIOUnity.Shutdown(null);
			}
		}

		private void OnTabButtonClicked(int index)
		{
			foreach (var view in _views)
			{
				view.style.display = DisplayStyle.None;
			}

			foreach (var button in _buttons)
			{
				button.pickingMode = PickingMode.Position;
			}

			// Show the associated view of the clicked button
			_views[index].style.display = DisplayStyle.Flex;
			// Make the pressed button unpressable
			_buttons[index].pickingMode = PickingMode.Ignore;
			
			_uploadMod.Refresh();
			_createMod.Refresh();
		}

		private void UpdateButtons(VisualElement root, bool loggedIn)
		{
			var logInButton = root.Q<Button>("LogInTabButton");
			logInButton.style.display = loggedIn ? DisplayStyle.None : DisplayStyle.Flex;

			var uploadButton = root.Q<Button>("UploadModTabButton");
			uploadButton.style.display = loggedIn ? DisplayStyle.Flex : DisplayStyle.None;
		}

		private static bool InitializeModIO()
		{
			if (!ModIOUnity.IsInitialized())
			{
#if PUG_MODIO_TEST_ENVIRONMENT
				ServerSettings serverSettings = new ServerSettings();
				serverSettings.serverURL = "https://api.test.mod.io/v1";
				serverSettings.gameId = 1085;
				serverSettings.gameKey = "439b2418cf2a7e570994a32e856b55da";

				BuildSettings buildSettings = new BuildSettings();
				buildSettings.logLevel = LogLevel.Verbose;
				buildSettings.userPortal = UserPortal.None;

				Result result = ModIOUnity.InitializeForUser("PugModSDKUser", serverSettings, buildSettings);
#else
				Result result = ModIOUnity.InitializeForUser("PugModSDKUser");
#endif
				if (!result.Succeeded())
				{
					Debug.Log("Failed to initialize mod.io SDK");
					return false;
				}
			}

			return true;
		}

		private void LogInModIO()
		{
			if (!InitializeModIO())
			{
				return;
			}

			TextInputPopup.ShowWindow("Log in to mod.io", "Email:", "Submit", "Cancel", "", email =>
			{
				var requestAuthenticationTask = ModIOUnityAsync.RequestAuthenticationEmail(email);

				EditorApplication.update += WaitAuthenticationEmailTask;

				void WaitAuthenticationEmailTask()
				{
					if (requestAuthenticationTask.IsCompleted)
					{
						EditorApplication.update -= WaitAuthenticationEmailTask; // Unregister the update

						Result result = requestAuthenticationTask.Result;

						if (!result.Succeeded())
						{
							Debug.Log("Failed to send security code to that email address");
							ShowError($"Failed to log in with the email address {email}");
							return;
						}

						TextInputPopup.ShowWindow("Enter security code", "Code:", "Submit", "Cancel", "", code =>
						{
							var submitTask = ModIOUnityAsync.SubmitEmailSecurityCode(code);

							EditorApplication.update += WaitSubmitEmailTask;

							void WaitSubmitEmailTask()
							{
								if (submitTask.IsCompleted)
								{
									EditorApplication.update -= WaitSubmitEmailTask;

									if (!result.Succeeded())
									{
										Debug.Log("Failed to authenticate the user");
										ShowError($"Wrong security code for logging ");
										return;
									}

									Debug.Log("You have successfully authenticated the user");
									UpdateButtons(rootVisualElement, true);
								}
							}
						});
					}
				}
			});
		}

		public static void ShowError(string message)
		{
			EditorUtility.DisplayDialog("Error", message, "OK");
		}
	}
}