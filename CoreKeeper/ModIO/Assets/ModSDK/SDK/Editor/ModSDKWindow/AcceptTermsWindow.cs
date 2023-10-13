using System;
using ModIO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;

namespace PugMod
{
	public partial class AcceptTermsWindow : EditorWindow
	{
		private const string ACCEPTED_TERMS_KEY = "PugMod/AcceptTerms/AcceptedTerms";

		private const string TERMS_URL = "https://raw.githubusercontent.com/Pugstorm/CoreKeeperModSDK/main/EULA.txt";

		private static Action<bool> AcceptDenyCallback { get; set; }
		private static string TermsToAccept { get; set; }
		
#if !PUG_MOD_SDK
		[MenuItem("PugMod/Clear accepted terms")]
		public static void ClearAcceptedTerms()
		{
			EditorPrefs.DeleteKey(ACCEPTED_TERMS_KEY);
		}
#endif

		public static void CheckIfTermsAccepted(Action<bool> callback)
		{
			UnityWebRequest www = UnityWebRequest.Get(TERMS_URL);
			www.SendWebRequest().completed += operation =>
			{
				string terms;
				if (www.result == UnityWebRequest.Result.Success)
				{
					terms = www.downloadHandler.text;
					
					if (EditorPrefs.HasKey(ACCEPTED_TERMS_KEY) && string.Equals(terms, EditorPrefs.GetString(ACCEPTED_TERMS_KEY)))
					{
						// We have accepted these terms
						callback?.Invoke(true);
						return;
					}
				}
				else if (EditorPrefs.HasKey(ACCEPTED_TERMS_KEY))
				{
					// Assume that any terms accepted are as good or better as default
					callback?.Invoke(true);
					return;
				}
				else
				{
					terms = DEFAULT_TERMS;
				}

				AcceptDenyCallback = callback;
				TermsToAccept = terms;

				AcceptTermsWindow wnd = GetWindow<AcceptTermsWindow>("EULA");

				wnd.minSize = new Vector2(600, 400);
				// Want to set size without messing with position so doing it in a somewhat hacky way
				var oldMaxSize = wnd.maxSize;
				wnd.maxSize = new Vector2(600, 400);
				wnd.maxSize = oldMaxSize;
				
				www.Dispose();
			};
		}

		private void OnDestroy()
		{
			AcceptDenyCallback?.Invoke(false);
		}

		public void CreateGUI()
		{
			if (string.IsNullOrEmpty(TermsToAccept))
			{
				// Null ref if Close is called directly from here
				EditorApplication.delayCall += Close;
			}
			
			// Each editor window contains a root VisualElement object
			VisualElement root = rootVisualElement;

			// Import UXML
			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/ModSDK/UI/AcceptTermsPopUp.uxml");

			root.Add(uxml.CloneTree());

			root.Q<Button>("AcceptButton").clicked += () =>
			{
				EditorPrefs.SetString(ACCEPTED_TERMS_KEY, TermsToAccept);
				AcceptDenyCallback?.Invoke(true);
				AcceptDenyCallback = null;
				Close();
			};

			root.Q<Button>("DenyButton").clicked += () =>
			{
				Close();
			};

			var contentLabel = root.Q<Label>("TermsText");
			if (contentLabel == null)
			{
				EditorApplication.delayCall += Close;
			}

			contentLabel.text = TermsToAccept;
		}

		private const string DEFAULT_TERMS = @"END USER LICENSE AGREEMENT (“EULA”)

<b>IMPORTANT</b> - READ CAREFULLY BEFORE INSTALLING, ACCESSING OR USING THE MOD TOOL

Pugstorm AB, a company registered in Sweden, with offices Slöjdgatan 3, 582 56 Linköping, Sweden (“Pugstorm”, “we”, “us”) is the developer and owner of the computer/video game known as ‘Core Keeper’ (the “Game”). Pugstorm has developed certain tools consisting of project files that are loaded in the game engine Unity to allow users of the Game to modify in-game assets of the Game (the “Mod Tool”). Modifications to the game are referred to as “Mods”.

<b>By installing, accessing, copying, and/or otherwise using the Mod Tool you agree to be bound by the terms of this EULA.</b>

We encourage you to read all the terms of this EULA but to help you, here is a summary of the key points:

 - <indent=3%>We have created some tools to enable you make mods for the Game</indent>

 - <indent=3%>We are freely sharing these tools to you but remember these tools belong to us, along with any improvements you make to them</indent>

 - <indent=3%>You own the mods that you make and can distribute them freely but not for any commercial purpose without permission from us</indent>

 - <indent=3%>We may change your mods where the law requires us to or for security and technical reasons</indent>

 - <indent=3%>We may make mods that are similar to your mods and they will belong to us. We may change this EULA from time to time but will let you know when we do</indent>

The Mod Tool(which includes the computer software program, the associated media, if applicable), is licensed to you on the terms set forth below, which constitutes a legal agreement between you and Pugstorm.

<b>If you do not agree to the terms of this EULA, you are not authorized to use the Mod Tool and you should not install the Mod Tool.</b>

The terms and conditions of this EULA are without prejudice to any terms and conditions governing your use of any third party proprietary software product including any open source software that may be incorporated into any separate plugins, delivery systems or other software programs. Such third party proprietary software may be required in order to use certain features of this Mod Tool which use may be subject to and conditional upon your acceptance and observance of additional third party end user licence agreements.

<b>License and Rights</b>

The Mod Tool is protected by applicable copyright law, international copyright treaties and conventions and other laws.  The Mod Tool is licensed, and not sold, and this EULA confers no title or ownership to the Mod Tool or any copy thereof.

Pugstorm grants you the non-exclusive, limited right and license to use the Mod Tool solely for your non-commercial personal use for the creation of Mods. This right and license is not transferrable or assignable and you may not grant any sublicenses. You may not use any part of the Mod Tool for anything other than the creation of your Mods.

<b>Restrictions on Mod Tool</b>

<b>You agree that you will not:</b>

 - <indent=3%>copy the Mod Tool except as permitted under this EULA</indent>

 - <indent=3%>make any commercial use or exploitation of the Mod Tool in any manner whatsoever</indent>

 - <indent=3%>sell, rent, lease, license, distribute, upload or otherwise transfer or make available to any other person the Mod Tool other than for the purpose of making improvements to the Mod Tool</indent> 

 - <indent=3%>except as the applicable law expressly permits, or upon written permission from Pugstorm to reverse engineer, derive source code, modify, decompile, disassemble, or create derivative works based on the whole or any part of the Mod Tool and where applicable law expressly permits any such acts, and any lawful modifications, adaptations and improvements, any and all intellectual property rights (including copyright) therein shall be deemed assigned to and shall belong to, vest in and be the exclusive property of Pugstorm to the maximum extent permitted by law and you hereby waive all or any moral rights in such creations</indent>

 - <indent=3%>export or re-export the Mod Tool or any copy or adaptation in violation of any applicable laws or regulations</indent>

Notwithstanding any of the foregoing, you may “fork” the Mod Tool to make changes and derivative versions of the Mod Tool. Such changes will be owned, (and are hereby assigned to Pugstorm) and may be incorporated into the Mod Tool at our request.

<b>Right to create and use Mods</b>

You may use, reproduce, publish, perform, display and distribute any Mods created and developed by you with the Mod Tool but solely as part of the Game (not on a stand-alone basis) and only on a non-commercial basis.

You agree that you will not rent, lease, license, distribute, upload or otherwise transfer or make available to any other person the Mods (and/or any files of the Mod created by the Mod Tool) directly or indirectly for a commercial or other business purpose.

Pugstorm does not claim any ownership in your Mods or claim any intellectual property rights in them. Notwithstanding the foregoing all rights, including all intellectual property rights relating to the Game and/or it’s consistent parts and/or content (including but not limited to characters, artwork, storylines, audio, dialogue, graphical interfaces and text) are and will remain owned by Pugstorm. You accept that we may independently from you or your Mods create or develop and, in each case, publish in the future content for the Game that is similar or identical with content of your Mods. You waive any copyright or other intellectual property right claims you may have against Pugstorm due to such similar or identical content.

When you make your Mods available to other users and/or to Pugstorm, You hereby grant to PugStorm an irrevocable, perpetual, royalty-free, fully paid, worldwide, non-exclusive right and license, with the right to sublicense through multiple tiers of distribution, to:

 - <indent=3%>use, reproduce, modify and create derivative works from the Mods;</indent>

 - <indent=3%>make modifications to the Mods as Pugstorm deems necessary or desirable to enhance gameplay;</indent>

 - <indent=3%>where Pugstorm in its sole discretion deems modification necessary for security, statutory or other regulatory consideration), distribute, transmit, transcode, translate, broadcast, and otherwise communicate, publicly display and publicly perform and otherwise exploit and/or dispose of Mods (in whole or in part.</indent>

This license is granted to Pugstorm for the entire duration of the intellectual property rights in or protecting the Mods.  To the fullest extent permitted by law You also waive and agree never to assert against Pugstorm or its distributors or licensors any moral rights or similar rights, however designated, that You may have in or to any of the Mods.  Subject to Your ownership of the original of Your Mods, Pugstorm will be the sole owner of the modifications and derivative works created by Pugstorm of Your Mods and is entited to grant licenses of such works.   For clarity, You agree that You are not entitled to any rights or compensation in connection with the rights granted to Pugstorm in this Agreement, including without limitation the use of Your Mods by others.

You warrant and represent that your Mods will comply with all applicable laws, rules, regulations and orders and will not infringe any third party’s rights. Pugstorm excludes any and all liability for use of your Mods by you and/or use by a third party.

Pugstorm does not and will not control or endorse your Mods and assumes no responsibility for monitoring the Mods for inappropriate or illegal content unless required by applicable law.

Pugstrom may choose at any time, in its sole discretion (or required by applicable law), to monitor the Mods. In such event, Pugstorm shall have the right, in its sole discretion, to edit, refuse to post/upload, or remove any Mods that have been publicly distributed.

You shall indemnify and hold Pugstorm harmless at your own expense from any action against Pugstorm brought by a third party to the extent that such action is based upon a claim alleging that your Mod or your use of the Mod Tool infringes or misappropriates any copyright, trademark, or other proprietary or intellectual property right or violates any third party rights or applicable laws and/or you breach a representation or warranty or obligation under this EULA.

If you provide Pugstorm with any feedback or suggestions about the Mod Tool, or any of Pugstorms products (including any Mods Pugstorm creates), Pugstorm is free to use the feedback or suggestions however it chooses, without any obligation to account to you.

<b>Use of Data</b>

You agree that Pugstorm may collect and use technical data and related information, including but not limited to technical information about Your device, system and application software and peripherals, that is gathered periodically to facilitate the provision of software updates, product support, and other services (to You (if any) related to the Mod Tool.  Pugstorm may use this information, as long as it is in a form that does not personally identify You to improve it’s products or to provide services or technologies to You.

<b>Exclusions and Limitations</b>

The Mod Tool is provided ‘as is’ and this warranty is in lieu of all other warranties, whether oral or written, express or implied, including any warranty of merchantability, satisfactory quality, fitness for a particular purpose or non-infringement, and no other representations or claims of any kind shall be binding on or obligate Pugstorm and with regard to the Mod Tool and each and every part thereof, without prejudice to the generality of the foregoing, Pugstorm does not warrant that the Mod Toolis error-free or that it will operate without interruption, nor that Pugstorm will repair any errors in the Mod Tool.

To the maximum extent permitted by applicable law, in no event shall Pugstorm be liable for any damages whatsoever (including, but not limited to, direct, indirect, incidental or consequential damages for loss of profits, business interruption, loss of information, or any pecuniary loss) arising out of the use of or inability to use the Mod Tool(or any Mod created by you), even if Pugstorm has been advised of the possibility of such damages.

Nothing in this EULA shall limit or exclude Pugstorm’s liability to you in negligence for death or personal injury, to the extent such exclusion or limitation is unlawful, unenforceable or void under any applicable law.

This EULA represents the complete agreement concerning this license between the parties and supersedes all prior agreements and representations between them.

Each party may terminate the license any time. Upon any termination of the license, all of your rights hereunder shall immediately cease and you will delete the Mod Tool(including copies thereof) in your possession or control and must cease creating and distributing Mods.

This EULA shall be governed by and construed in accordance with the laws of Sweden and you consent to the exclusive jurisdiction of the courts of Sweden.

From time to time this EULA may be updated by Pugstorm. Any changes will be communicated to you by posting a notice or by other reasonable means.
";
	}
}