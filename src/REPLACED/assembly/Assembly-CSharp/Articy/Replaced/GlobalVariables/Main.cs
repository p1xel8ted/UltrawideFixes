// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.GlobalVariables.Main
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.GlobalVariables;

[Serializable]
public class Main(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__VariableStorage;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station1_after_bar_cutscene_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station1_after_bar_cutscene_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station1_gun_fixed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station1_gun_fixed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station2_bar_fight_cutscene_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station2_bar_fight_cutscene_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station3_matriarch_on_enter_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station3_matriarch_on_enter_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station3_hospital_scene_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station3_hospital_scene_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station3_terminal_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station3_terminal_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station3_address_found_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station3_address_found_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station3_terminal_hacked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station3_terminal_hacked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station3_address_access_denied_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station3_address_access_denied_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_station1_after_bar_tempest_rant_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_station1_after_bar_tempest_rant_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_step_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_step_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_kitchen_puzzle_counter_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_kitchen_puzzle_counter_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_hint_read_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_hint_read_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_clues_found_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_clues_found_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_safe_opened_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_safe_opened_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_clue1_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_clue1_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_clue2_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_clue2_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_clue3_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_clue3_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_clue4_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_clue4_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_clue5_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_clue5_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_warren_password_words_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_warren_password_words_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_minerlight_on_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_minerlight_on_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_gates_reloaded_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_gates_reloaded_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_card_taken_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_card_taken_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_bank_tech_spoken_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_bank_tech_spoken_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_music_tech_spoken_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_music_tech_spoken_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_food_tech_spoken_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_food_tech_spoken_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_music_found_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_music_found_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_bank_server_hacked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_bank_server_hacked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_food_hacked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_food_hacked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_techinians_found_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_techinians_found_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_food_tech_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_food_tech_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_bank_tech_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_bank_tech_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_shady_tech_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_shady_tech_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_music_tech_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_music_tech_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_casette_found_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_casette_found_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_bank_queue_hacked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_bank_queue_hacked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_stall_check_counter_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_stall_check_counter_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_stall_exit_counter_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_stall_exit_counter_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_poster_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_poster_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_music_shop_owner_status_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_music_shop_owner_status_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_music_shop_hint_check_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_music_shop_hint_check_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_yoyo_after_siege_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_yoyo_after_siege_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_veronica_after_siege_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_veronica_after_siege_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_termitlair_progress_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_termitlair_progress_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_adrian_mail_checked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_adrian_mail_checked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_technicians_finished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_technicians_finished_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msq_kitchen_puzzle_solved_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msq_kitchen_puzzle_solved_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterVariables_Public_Virtual_Final_New_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Main()
  {
    Il2CppClassPointerStore<Main>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.GlobalVariables", nameof (Main));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Main>.NativeClassPtr);
    Main.NativeFieldInfoPtr__VariableStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, nameof (_VariableStorage));
    Main.NativeMethodInfoPtr_get_station1_after_bar_cutscene_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679796);
    Main.NativeMethodInfoPtr_set_station1_after_bar_cutscene_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679797);
    Main.NativeMethodInfoPtr_get_station1_gun_fixed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679798);
    Main.NativeMethodInfoPtr_set_station1_gun_fixed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679799);
    Main.NativeMethodInfoPtr_get_station2_bar_fight_cutscene_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679800);
    Main.NativeMethodInfoPtr_set_station2_bar_fight_cutscene_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679801);
    Main.NativeMethodInfoPtr_get_station3_matriarch_on_enter_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679802);
    Main.NativeMethodInfoPtr_set_station3_matriarch_on_enter_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679803);
    Main.NativeMethodInfoPtr_get_station3_hospital_scene_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679804);
    Main.NativeMethodInfoPtr_set_station3_hospital_scene_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679805);
    Main.NativeMethodInfoPtr_get_station3_terminal_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679806);
    Main.NativeMethodInfoPtr_set_station3_terminal_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679807);
    Main.NativeMethodInfoPtr_get_station3_address_found_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679808 /*0x06004080*/);
    Main.NativeMethodInfoPtr_set_station3_address_found_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679809);
    Main.NativeMethodInfoPtr_get_station3_terminal_hacked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679810);
    Main.NativeMethodInfoPtr_set_station3_terminal_hacked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679811);
    Main.NativeMethodInfoPtr_get_station3_address_access_denied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679812);
    Main.NativeMethodInfoPtr_set_station3_address_access_denied_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679813);
    Main.NativeMethodInfoPtr_get_station1_after_bar_tempest_rant_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679814);
    Main.NativeMethodInfoPtr_set_station1_after_bar_tempest_rant_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679815);
    Main.NativeMethodInfoPtr_get_msq_step_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679816);
    Main.NativeMethodInfoPtr_set_msq_step_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679817);
    Main.NativeMethodInfoPtr_get_msq_kitchen_puzzle_counter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679818);
    Main.NativeMethodInfoPtr_set_msq_kitchen_puzzle_counter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679819);
    Main.NativeMethodInfoPtr_get_msq_warren_hint_read_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679820);
    Main.NativeMethodInfoPtr_set_msq_warren_hint_read_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679821);
    Main.NativeMethodInfoPtr_get_msq_warren_clues_found_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679822);
    Main.NativeMethodInfoPtr_set_msq_warren_clues_found_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679823);
    Main.NativeMethodInfoPtr_get_msq_warren_safe_opened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679824 /*0x06004090*/);
    Main.NativeMethodInfoPtr_set_msq_warren_safe_opened_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679825);
    Main.NativeMethodInfoPtr_get_msq_warren_clue1_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679826);
    Main.NativeMethodInfoPtr_set_msq_warren_clue1_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679827);
    Main.NativeMethodInfoPtr_get_msq_warren_clue2_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679828);
    Main.NativeMethodInfoPtr_set_msq_warren_clue2_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679829);
    Main.NativeMethodInfoPtr_get_msq_warren_clue3_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679830);
    Main.NativeMethodInfoPtr_set_msq_warren_clue3_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679831);
    Main.NativeMethodInfoPtr_get_msq_warren_clue4_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679832);
    Main.NativeMethodInfoPtr_set_msq_warren_clue4_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679833);
    Main.NativeMethodInfoPtr_get_msq_warren_clue5_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679834);
    Main.NativeMethodInfoPtr_set_msq_warren_clue5_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679835);
    Main.NativeMethodInfoPtr_get_msq_warren_password_words_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679836);
    Main.NativeMethodInfoPtr_set_msq_warren_password_words_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679837);
    Main.NativeMethodInfoPtr_get_msq_minerlight_on_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679838);
    Main.NativeMethodInfoPtr_set_msq_minerlight_on_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679839);
    Main.NativeMethodInfoPtr_get_msq_gates_reloaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679840 /*0x060040A0*/);
    Main.NativeMethodInfoPtr_set_msq_gates_reloaded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679841);
    Main.NativeMethodInfoPtr_get_msq_card_taken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679842);
    Main.NativeMethodInfoPtr_set_msq_card_taken_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679843);
    Main.NativeMethodInfoPtr_get_msq_bank_tech_spoken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679844);
    Main.NativeMethodInfoPtr_set_msq_bank_tech_spoken_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679845);
    Main.NativeMethodInfoPtr_get_msq_music_tech_spoken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679846);
    Main.NativeMethodInfoPtr_set_msq_music_tech_spoken_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679847);
    Main.NativeMethodInfoPtr_get_msq_food_tech_spoken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679848);
    Main.NativeMethodInfoPtr_set_msq_food_tech_spoken_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679849);
    Main.NativeMethodInfoPtr_get_msq_music_found_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679850);
    Main.NativeMethodInfoPtr_set_msq_music_found_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679851);
    Main.NativeMethodInfoPtr_get_msq_bank_server_hacked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679852);
    Main.NativeMethodInfoPtr_set_msq_bank_server_hacked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679853);
    Main.NativeMethodInfoPtr_get_msq_food_hacked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679854);
    Main.NativeMethodInfoPtr_set_msq_food_hacked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679855);
    Main.NativeMethodInfoPtr_get_msq_techinians_found_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679856 /*0x060040B0*/);
    Main.NativeMethodInfoPtr_set_msq_techinians_found_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679857);
    Main.NativeMethodInfoPtr_get_msq_food_tech_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679858);
    Main.NativeMethodInfoPtr_set_msq_food_tech_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679859);
    Main.NativeMethodInfoPtr_get_msq_bank_tech_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679860);
    Main.NativeMethodInfoPtr_set_msq_bank_tech_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679861);
    Main.NativeMethodInfoPtr_get_msq_shady_tech_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679862);
    Main.NativeMethodInfoPtr_set_msq_shady_tech_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679863);
    Main.NativeMethodInfoPtr_get_msq_music_tech_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679864);
    Main.NativeMethodInfoPtr_set_msq_music_tech_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679865);
    Main.NativeMethodInfoPtr_get_msq_casette_found_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679866);
    Main.NativeMethodInfoPtr_set_msq_casette_found_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679867);
    Main.NativeMethodInfoPtr_get_msq_bank_queue_hacked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679868);
    Main.NativeMethodInfoPtr_set_msq_bank_queue_hacked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679869);
    Main.NativeMethodInfoPtr_get_msq_stall_check_counter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679870);
    Main.NativeMethodInfoPtr_set_msq_stall_check_counter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679871);
    Main.NativeMethodInfoPtr_get_msq_stall_exit_counter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679872 /*0x060040C0*/);
    Main.NativeMethodInfoPtr_set_msq_stall_exit_counter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679873);
    Main.NativeMethodInfoPtr_get_msq_poster_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679874);
    Main.NativeMethodInfoPtr_set_msq_poster_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679875);
    Main.NativeMethodInfoPtr_get_msq_music_shop_owner_status_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679876);
    Main.NativeMethodInfoPtr_set_msq_music_shop_owner_status_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679877);
    Main.NativeMethodInfoPtr_get_msq_music_shop_hint_check_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679878);
    Main.NativeMethodInfoPtr_set_msq_music_shop_hint_check_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679879);
    Main.NativeMethodInfoPtr_get_msq_yoyo_after_siege_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679880);
    Main.NativeMethodInfoPtr_set_msq_yoyo_after_siege_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679881);
    Main.NativeMethodInfoPtr_get_veronica_after_siege_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679882);
    Main.NativeMethodInfoPtr_set_veronica_after_siege_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679883);
    Main.NativeMethodInfoPtr_get_msq_termitlair_progress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679884);
    Main.NativeMethodInfoPtr_set_msq_termitlair_progress_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679885);
    Main.NativeMethodInfoPtr_get_msq_adrian_mail_checked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679886);
    Main.NativeMethodInfoPtr_set_msq_adrian_mail_checked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679887);
    Main.NativeMethodInfoPtr_get_msq_technicians_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679888 /*0x060040D0*/);
    Main.NativeMethodInfoPtr_set_msq_technicians_finished_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679889);
    Main.NativeMethodInfoPtr_get_msq_kitchen_puzzle_solved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679890);
    Main.NativeMethodInfoPtr_set_msq_kitchen_puzzle_solved_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679891);
    Main.NativeMethodInfoPtr_RegisterVariables_Public_Virtual_Final_New_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679892);
    Main.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100679893);
  }

  public unsafe bool station1_after_bar_cutscene
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 146640, RefRangeEnd = 146646, XrefRangeStart = 146638, XrefRangeEnd = 146640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station1_after_bar_cutscene_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146648, RefRangeEnd = 146650, XrefRangeStart = 146646, XrefRangeEnd = 146648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station1_after_bar_cutscene_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station1_gun_fixed
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146652, RefRangeEnd = 146654, XrefRangeStart = 146650, XrefRangeEnd = 146652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station1_gun_fixed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146656, RefRangeEnd = 146658, XrefRangeStart = 146654, XrefRangeEnd = 146656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station1_gun_fixed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station2_bar_fight_cutscene
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 146660, RefRangeEnd = 146661, XrefRangeStart = 146658, XrefRangeEnd = 146660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station2_bar_fight_cutscene_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146663, RefRangeEnd = 146665, XrefRangeStart = 146661, XrefRangeEnd = 146663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station2_bar_fight_cutscene_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station3_matriarch_on_enter_finished
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 146667, RefRangeEnd = 146668, XrefRangeStart = 146665, XrefRangeEnd = 146667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station3_matriarch_on_enter_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146670, RefRangeEnd = 146671, XrefRangeStart = 146668, XrefRangeEnd = 146670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station3_matriarch_on_enter_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station3_hospital_scene_finished
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146673, RefRangeEnd = 146675, XrefRangeStart = 146671, XrefRangeEnd = 146673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station3_hospital_scene_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146677, RefRangeEnd = 146679, XrefRangeStart = 146675, XrefRangeEnd = 146677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station3_hospital_scene_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station3_terminal_checked
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 146681, RefRangeEnd = 146684, XrefRangeStart = 146679, XrefRangeEnd = 146681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station3_terminal_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146686, RefRangeEnd = 146688, XrefRangeStart = 146684, XrefRangeEnd = 146686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station3_terminal_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station3_address_found
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146690, RefRangeEnd = 146692, XrefRangeStart = 146688, XrefRangeEnd = 146690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station3_address_found_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146694, RefRangeEnd = 146696, XrefRangeStart = 146692, XrefRangeEnd = 146694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station3_address_found_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station3_terminal_hacked
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146696, XrefRangeEnd = 146698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station3_terminal_hacked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146700, RefRangeEnd = 146701, XrefRangeStart = 146698, XrefRangeEnd = 146700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station3_terminal_hacked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station3_address_access_denied
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 146703, RefRangeEnd = 146704, XrefRangeStart = 146701, XrefRangeEnd = 146703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station3_address_access_denied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146704, XrefRangeEnd = 146706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station3_address_access_denied_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool station1_after_bar_tempest_rant
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146708, RefRangeEnd = 146710, XrefRangeStart = 146706, XrefRangeEnd = 146708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_station1_after_bar_tempest_rant_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146712, RefRangeEnd = 146713, XrefRangeStart = 146710, XrefRangeEnd = 146712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_station1_after_bar_tempest_rant_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_step
  {
    [CallerCount(71), CachedScanResults(RefRangeStart = 146715, RefRangeEnd = 146786, XrefRangeStart = 146713, XrefRangeEnd = 146715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_step_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(38), CachedScanResults(RefRangeStart = 146788, RefRangeEnd = 146826, XrefRangeStart = 146786, XrefRangeEnd = 146788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_step_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_kitchen_puzzle_counter
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 146828, RefRangeEnd = 146834, XrefRangeStart = 146826, XrefRangeEnd = 146828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_kitchen_puzzle_counter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 146836, RefRangeEnd = 146841, XrefRangeStart = 146834, XrefRangeEnd = 146836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_kitchen_puzzle_counter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_hint_read
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146843, RefRangeEnd = 146845, XrefRangeStart = 146841, XrefRangeEnd = 146843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_hint_read_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146847, RefRangeEnd = 146848, XrefRangeStart = 146845, XrefRangeEnd = 146847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_hint_read_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_clues_found
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 146850, RefRangeEnd = 146855, XrefRangeStart = 146848, XrefRangeEnd = 146850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_clues_found_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146857, RefRangeEnd = 146858, XrefRangeStart = 146855, XrefRangeEnd = 146857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_clues_found_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_safe_opened
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 146860, RefRangeEnd = 146861, XrefRangeStart = 146858, XrefRangeEnd = 146860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_safe_opened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146863, RefRangeEnd = 146864, XrefRangeStart = 146861, XrefRangeEnd = 146863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_safe_opened_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_clue1_checked
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 146866, RefRangeEnd = 146873, XrefRangeStart = 146864, XrefRangeEnd = 146866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_clue1_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146875, RefRangeEnd = 146876, XrefRangeStart = 146873, XrefRangeEnd = 146875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_clue1_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_clue2_checked
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 146878, RefRangeEnd = 146885, XrefRangeStart = 146876, XrefRangeEnd = 146878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_clue2_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146887, RefRangeEnd = 146888, XrefRangeStart = 146885, XrefRangeEnd = 146887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_clue2_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_clue3_checked
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 146890, RefRangeEnd = 146897, XrefRangeStart = 146888, XrefRangeEnd = 146890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_clue3_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146899, RefRangeEnd = 146900, XrefRangeStart = 146897, XrefRangeEnd = 146899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_clue3_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_clue4_checked
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 146902, RefRangeEnd = 146909, XrefRangeStart = 146900, XrefRangeEnd = 146902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_clue4_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146911, RefRangeEnd = 146912, XrefRangeStart = 146909, XrefRangeEnd = 146911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_clue4_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_warren_clue5_checked
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 146914, RefRangeEnd = 146921, XrefRangeStart = 146912, XrefRangeEnd = 146914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_clue5_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146923, RefRangeEnd = 146924, XrefRangeStart = 146921, XrefRangeEnd = 146923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_clue5_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_warren_password_words
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 146926, RefRangeEnd = 146930, XrefRangeStart = 146924, XrefRangeEnd = 146926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_warren_password_words_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 146932, RefRangeEnd = 146936, XrefRangeStart = 146930, XrefRangeEnd = 146932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_warren_password_words_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_minerlight_on
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 146938, RefRangeEnd = 146941, XrefRangeStart = 146936, XrefRangeEnd = 146938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_minerlight_on_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146943, RefRangeEnd = 146944, XrefRangeStart = 146941, XrefRangeEnd = 146943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_minerlight_on_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_gates_reloaded
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146946, RefRangeEnd = 146948, XrefRangeStart = 146944, XrefRangeEnd = 146946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_gates_reloaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146950, RefRangeEnd = 146951, XrefRangeStart = 146948, XrefRangeEnd = 146950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_gates_reloaded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_card_taken
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 146953, RefRangeEnd = 146956, XrefRangeStart = 146951, XrefRangeEnd = 146953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_card_taken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146958, RefRangeEnd = 146959, XrefRangeStart = 146956, XrefRangeEnd = 146958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_card_taken_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_bank_tech_spoken
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 146961, RefRangeEnd = 146966, XrefRangeStart = 146959, XrefRangeEnd = 146961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_bank_tech_spoken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 146968, RefRangeEnd = 146970, XrefRangeStart = 146966, XrefRangeEnd = 146968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_bank_tech_spoken_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_music_tech_spoken
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 146972, RefRangeEnd = 146982, XrefRangeStart = 146970, XrefRangeEnd = 146972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_music_tech_spoken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146984, RefRangeEnd = 146985, XrefRangeStart = 146982, XrefRangeEnd = 146984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_music_tech_spoken_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_food_tech_spoken
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 146987, RefRangeEnd = 146989, XrefRangeStart = 146985, XrefRangeEnd = 146987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_food_tech_spoken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 146991, RefRangeEnd = 146992, XrefRangeStart = 146989, XrefRangeEnd = 146991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_food_tech_spoken_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_music_found
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146992, XrefRangeEnd = 146994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_music_found_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146994, XrefRangeEnd = 146996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_music_found_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_bank_server_hacked
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 146998, RefRangeEnd = 147001, XrefRangeStart = 146996, XrefRangeEnd = 146998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_bank_server_hacked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147003, RefRangeEnd = 147004, XrefRangeStart = 147001, XrefRangeEnd = 147003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_bank_server_hacked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_food_hacked
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 147006, RefRangeEnd = 147009, XrefRangeStart = 147004, XrefRangeEnd = 147006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_food_hacked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147011, RefRangeEnd = 147012, XrefRangeStart = 147009, XrefRangeEnd = 147011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_food_hacked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_techinians_found
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 147014, RefRangeEnd = 147024, XrefRangeStart = 147012, XrefRangeEnd = 147014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_techinians_found_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147026, RefRangeEnd = 147030, XrefRangeStart = 147024, XrefRangeEnd = 147026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_techinians_found_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_food_tech_finished
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147032, RefRangeEnd = 147033, XrefRangeStart = 147030, XrefRangeEnd = 147032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_food_tech_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147035, RefRangeEnd = 147036, XrefRangeStart = 147033, XrefRangeEnd = 147035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_food_tech_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_bank_tech_finished
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147038, RefRangeEnd = 147039, XrefRangeStart = 147036, XrefRangeEnd = 147038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_bank_tech_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147041, RefRangeEnd = 147042, XrefRangeStart = 147039, XrefRangeEnd = 147041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_bank_tech_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_shady_tech_finished
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147044, RefRangeEnd = 147045, XrefRangeStart = 147042, XrefRangeEnd = 147044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_shady_tech_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147047, RefRangeEnd = 147048, XrefRangeStart = 147045, XrefRangeEnd = 147047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_shady_tech_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_music_tech_finished
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 147050, RefRangeEnd = 147052, XrefRangeStart = 147048, XrefRangeEnd = 147050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_music_tech_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147054, RefRangeEnd = 147055, XrefRangeStart = 147052, XrefRangeEnd = 147054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_music_tech_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_casette_found
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 147057, RefRangeEnd = 147059, XrefRangeStart = 147055, XrefRangeEnd = 147057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_casette_found_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147061, RefRangeEnd = 147062, XrefRangeStart = 147059, XrefRangeEnd = 147061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_casette_found_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_bank_queue_hacked
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147064, RefRangeEnd = 147065, XrefRangeStart = 147062, XrefRangeEnd = 147064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_bank_queue_hacked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147067, RefRangeEnd = 147068, XrefRangeStart = 147065, XrefRangeEnd = 147067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_bank_queue_hacked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_stall_check_counter
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 147070, RefRangeEnd = 147078, XrefRangeStart = 147068, XrefRangeEnd = 147070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_stall_check_counter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 147080, RefRangeEnd = 147089, XrefRangeStart = 147078, XrefRangeEnd = 147080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_stall_check_counter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_stall_exit_counter
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147089, XrefRangeEnd = 147091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_stall_exit_counter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147093, RefRangeEnd = 147098, XrefRangeStart = 147091, XrefRangeEnd = 147093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_stall_exit_counter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_poster_checked
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147100, RefRangeEnd = 147104, XrefRangeStart = 147098, XrefRangeEnd = 147100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_poster_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 147106, RefRangeEnd = 147108, XrefRangeStart = 147104, XrefRangeEnd = 147106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_poster_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_music_shop_owner_status
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147110, RefRangeEnd = 147114, XrefRangeStart = 147108, XrefRangeEnd = 147110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_music_shop_owner_status_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 147116, RefRangeEnd = 147119, XrefRangeStart = 147114, XrefRangeEnd = 147116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_music_shop_owner_status_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_music_shop_hint_check
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 147121, RefRangeEnd = 147123, XrefRangeStart = 147119, XrefRangeEnd = 147121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_music_shop_hint_check_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147125, RefRangeEnd = 147126, XrefRangeStart = 147123, XrefRangeEnd = 147125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_music_shop_hint_check_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_yoyo_after_siege
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 147128, RefRangeEnd = 147130, XrefRangeStart = 147126, XrefRangeEnd = 147128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_yoyo_after_siege_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147132, RefRangeEnd = 147133, XrefRangeStart = 147130, XrefRangeEnd = 147132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_yoyo_after_siege_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool veronica_after_siege
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 147135, RefRangeEnd = 147137, XrefRangeStart = 147133, XrefRangeEnd = 147135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_veronica_after_siege_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147139, RefRangeEnd = 147140, XrefRangeStart = 147137, XrefRangeEnd = 147139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_veronica_after_siege_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msq_termitlair_progress
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147140, XrefRangeEnd = 147142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_termitlair_progress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147144, RefRangeEnd = 147148, XrefRangeStart = 147142, XrefRangeEnd = 147144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_termitlair_progress_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_adrian_mail_checked
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147150, RefRangeEnd = 147151, XrefRangeStart = 147148, XrefRangeEnd = 147150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_adrian_mail_checked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147153, RefRangeEnd = 147154, XrefRangeStart = 147151, XrefRangeEnd = 147153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_adrian_mail_checked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_technicians_finished
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147156, RefRangeEnd = 147157, XrefRangeStart = 147154, XrefRangeEnd = 147156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_technicians_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147159, RefRangeEnd = 147160, XrefRangeStart = 147157, XrefRangeEnd = 147159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_technicians_finished_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool msq_kitchen_puzzle_solved
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147162, RefRangeEnd = 147163, XrefRangeStart = 147160, XrefRangeEnd = 147162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_get_msq_kitchen_puzzle_solved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 147165, RefRangeEnd = 147166, XrefRangeStart = 147163, XrefRangeEnd = 147165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_set_msq_kitchen_puzzle_solved_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 147311, RefRangeEnd = 147312, XrefRangeStart = 147166, XrefRangeEnd = 147311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RegisterVariables(BaseGlobalVariables aStorage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStorage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_RegisterVariables_Public_Virtual_Final_New_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Main()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Main>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BaseGlobalVariables _VariableStorage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Main.NativeFieldInfoPtr__VariableStorage));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Main.NativeFieldInfoPtr__VariableStorage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
