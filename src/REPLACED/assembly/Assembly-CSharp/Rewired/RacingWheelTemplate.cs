// Decompiled with JetBrains decompiler
// Type: Rewired.RacingWheelTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired;

public sealed class RacingWheelTemplate(System.IntPtr pointer) : ControllerTemplate(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_accelerator;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_brake;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_clutch;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shiftDown;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shiftUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton1;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton2;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton3;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton4;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton5;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton6;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton7;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton8;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton9;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton10;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton1;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton2;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton3;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton4;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton5;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton6;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton7;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton8;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton9;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton10;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter1;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter2;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter3;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter4;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter5;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter6;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter7;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter8;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter9;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter10;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_reverseGear;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_select;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_start;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_systemButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_horn;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadDown;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPad;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

  static RacingWheelTemplate()
  {
    Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (RacingWheelTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr);
    RacingWheelTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (typeGuid));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheel));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_accelerator));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_brake));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_clutch));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shiftDown));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shiftUp));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton1));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton2));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton3));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton4));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton5));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton6));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton7));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton8));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton9));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton10));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton1));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton2));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton3));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton4));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton5));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton6));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton7));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton8));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton9));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton10));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter1));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter2));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter3));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter4));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter5));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter6));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter7));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter8));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter9));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter10));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_reverseGear));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_select));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_start));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_systemButton));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_horn));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadUp));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadRight));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadDown));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadLeft));
    RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPad));
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667834);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667835);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667836);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667837);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667838);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667839);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667840);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667841);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667842);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667843);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667844);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667845);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667846);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667847);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667848);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667849);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667850);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667851);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667852);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667853);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667854);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667855);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667856);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667857);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667858);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667859);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667860);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667861);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667862);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667863);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667864);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667865);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667866);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667867);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667868);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667869);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667870);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667871);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667872);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667873);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667874);
    RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667875);
    RacingWheelTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667876);
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Ewheel
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63831, XrefRangeEnd = 63839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Eaccelerator
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63839, XrefRangeEnd = 63842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Ebrake
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63842, XrefRangeEnd = 63845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Eclutch
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63845, XrefRangeEnd = 63848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EshiftDown
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63848, XrefRangeEnd = 63851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EshiftUp
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63851, XrefRangeEnd = 63854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton1
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63854, XrefRangeEnd = 63857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton2
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63857, XrefRangeEnd = 63860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton3
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63860, XrefRangeEnd = 63863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton4
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63863, XrefRangeEnd = 63866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton5
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63866, XrefRangeEnd = 63869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton6
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63869, XrefRangeEnd = 63872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton7
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63872, XrefRangeEnd = 63875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton8
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63875, XrefRangeEnd = 63878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton9
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63878, XrefRangeEnd = 63881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton10
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63881, XrefRangeEnd = 63884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton1
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63884, XrefRangeEnd = 63887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton2
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63887, XrefRangeEnd = 63890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton3
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63890, XrefRangeEnd = 63893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton4
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63893, XrefRangeEnd = 63896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton5
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63896, XrefRangeEnd = 63899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton6
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63899, XrefRangeEnd = 63902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton7
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63902, XrefRangeEnd = 63905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton8
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63905, XrefRangeEnd = 63908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton9
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63908, XrefRangeEnd = 63911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton10
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63911, XrefRangeEnd = 63914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter1
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63914, XrefRangeEnd = 63917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter2
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63917, XrefRangeEnd = 63920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter3
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63920, XrefRangeEnd = 63923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter4
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63923, XrefRangeEnd = 63926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter5
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63926, XrefRangeEnd = 63929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter6
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63929, XrefRangeEnd = 63932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter7
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63932, XrefRangeEnd = 63935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter8
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63935, XrefRangeEnd = 63938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter9
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63938, XrefRangeEnd = 63941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter10
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63941, XrefRangeEnd = 63944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EreverseGear
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63944, XrefRangeEnd = 63947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eselect
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63947, XrefRangeEnd = 63950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Estart
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63950, XrefRangeEnd = 63953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EsystemButton
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63953, XrefRangeEnd = 63956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Ehorn
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63956, XrefRangeEnd = 63959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateButton) null : Il2CppObjectPool.Get<IControllerTemplateButton>(num3);
    }
  }

  public virtual unsafe IControllerTemplateDPad Rewired\u002EIRacingWheelTemplate\u002EdPad
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63959, XrefRangeEnd = 63962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateDPad) null : Il2CppObjectPool.Get<IControllerTemplateDPad>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RacingWheelTemplate(Il2CppSystem.Object payload)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppSystem.Guid typeGuid
  {
    get
    {
      Il2CppSystem.Guid typeGuid;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
      return typeGuid;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
    }
  }

  public static unsafe int elementId_wheel
  {
    get
    {
      int elementIdWheel;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel, (void*) &elementIdWheel);
      return elementIdWheel;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel, (void*) &value);
    }
  }

  public static unsafe int elementId_accelerator
  {
    get
    {
      int elementIdAccelerator;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator, (void*) &elementIdAccelerator);
      return elementIdAccelerator;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator, (void*) &value);
    }
  }

  public static unsafe int elementId_brake
  {
    get
    {
      int elementIdBrake;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake, (void*) &elementIdBrake);
      return elementIdBrake;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake, (void*) &value);
    }
  }

  public static unsafe int elementId_clutch
  {
    get
    {
      int elementIdClutch;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch, (void*) &elementIdClutch);
      return elementIdClutch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch, (void*) &value);
    }
  }

  public static unsafe int elementId_shiftDown
  {
    get
    {
      int elementIdShiftDown;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown, (void*) &elementIdShiftDown);
      return elementIdShiftDown;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown, (void*) &value);
    }
  }

  public static unsafe int elementId_shiftUp
  {
    get
    {
      int elementIdShiftUp;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp, (void*) &elementIdShiftUp);
      return elementIdShiftUp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton1
  {
    get
    {
      int elementIdWheelButton1;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1, (void*) &elementIdWheelButton1);
      return elementIdWheelButton1;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton2
  {
    get
    {
      int elementIdWheelButton2;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2, (void*) &elementIdWheelButton2);
      return elementIdWheelButton2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton3
  {
    get
    {
      int elementIdWheelButton3;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3, (void*) &elementIdWheelButton3);
      return elementIdWheelButton3;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton4
  {
    get
    {
      int elementIdWheelButton4;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4, (void*) &elementIdWheelButton4);
      return elementIdWheelButton4;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton5
  {
    get
    {
      int elementIdWheelButton5;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5, (void*) &elementIdWheelButton5);
      return elementIdWheelButton5;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton6
  {
    get
    {
      int elementIdWheelButton6;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6, (void*) &elementIdWheelButton6);
      return elementIdWheelButton6;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton7
  {
    get
    {
      int elementIdWheelButton7;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7, (void*) &elementIdWheelButton7);
      return elementIdWheelButton7;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton8
  {
    get
    {
      int elementIdWheelButton8;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8, (void*) &elementIdWheelButton8);
      return elementIdWheelButton8;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton9
  {
    get
    {
      int elementIdWheelButton9;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9, (void*) &elementIdWheelButton9);
      return elementIdWheelButton9;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9, (void*) &value);
    }
  }

  public static unsafe int elementId_wheelButton10
  {
    get
    {
      int elementIdWheelButton10;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10, (void*) &elementIdWheelButton10);
      return elementIdWheelButton10;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton1
  {
    get
    {
      int idConsoleButton1;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*) &idConsoleButton1);
      return idConsoleButton1;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton2
  {
    get
    {
      int idConsoleButton2;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*) &idConsoleButton2);
      return idConsoleButton2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton3
  {
    get
    {
      int idConsoleButton3;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*) &idConsoleButton3);
      return idConsoleButton3;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton4
  {
    get
    {
      int idConsoleButton4;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*) &idConsoleButton4);
      return idConsoleButton4;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton5
  {
    get
    {
      int idConsoleButton5;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*) &idConsoleButton5);
      return idConsoleButton5;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton6
  {
    get
    {
      int idConsoleButton6;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*) &idConsoleButton6);
      return idConsoleButton6;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton7
  {
    get
    {
      int idConsoleButton7;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*) &idConsoleButton7);
      return idConsoleButton7;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton8
  {
    get
    {
      int idConsoleButton8;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*) &idConsoleButton8);
      return idConsoleButton8;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton9
  {
    get
    {
      int idConsoleButton9;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*) &idConsoleButton9);
      return idConsoleButton9;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*) &value);
    }
  }

  public static unsafe int elementId_consoleButton10
  {
    get
    {
      int idConsoleButton10;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*) &idConsoleButton10);
      return idConsoleButton10;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter1
  {
    get
    {
      int elementIdShifter1;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1, (void*) &elementIdShifter1);
      return elementIdShifter1;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter2
  {
    get
    {
      int elementIdShifter2;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2, (void*) &elementIdShifter2);
      return elementIdShifter2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter3
  {
    get
    {
      int elementIdShifter3;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3, (void*) &elementIdShifter3);
      return elementIdShifter3;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter4
  {
    get
    {
      int elementIdShifter4;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4, (void*) &elementIdShifter4);
      return elementIdShifter4;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter5
  {
    get
    {
      int elementIdShifter5;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5, (void*) &elementIdShifter5);
      return elementIdShifter5;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter6
  {
    get
    {
      int elementIdShifter6;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6, (void*) &elementIdShifter6);
      return elementIdShifter6;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter7
  {
    get
    {
      int elementIdShifter7;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7, (void*) &elementIdShifter7);
      return elementIdShifter7;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter8
  {
    get
    {
      int elementIdShifter8;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8, (void*) &elementIdShifter8);
      return elementIdShifter8;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter9
  {
    get
    {
      int elementIdShifter9;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9, (void*) &elementIdShifter9);
      return elementIdShifter9;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9, (void*) &value);
    }
  }

  public static unsafe int elementId_shifter10
  {
    get
    {
      int elementIdShifter10;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10, (void*) &elementIdShifter10);
      return elementIdShifter10;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10, (void*) &value);
    }
  }

  public static unsafe int elementId_reverseGear
  {
    get
    {
      int elementIdReverseGear;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear, (void*) &elementIdReverseGear);
      return elementIdReverseGear;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear, (void*) &value);
    }
  }

  public static unsafe int elementId_select
  {
    get
    {
      int elementIdSelect;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_select, (void*) &elementIdSelect);
      return elementIdSelect;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_select, (void*) &value);
    }
  }

  public static unsafe int elementId_start
  {
    get
    {
      int elementIdStart;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_start, (void*) &elementIdStart);
      return elementIdStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_start, (void*) &value);
    }
  }

  public static unsafe int elementId_systemButton
  {
    get
    {
      int elementIdSystemButton;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton, (void*) &elementIdSystemButton);
      return elementIdSystemButton;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton, (void*) &value);
    }
  }

  public static unsafe int elementId_horn
  {
    get
    {
      int elementIdHorn;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn, (void*) &elementIdHorn);
      return elementIdHorn;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn, (void*) &value);
    }
  }

  public static unsafe int elementId_dPadUp
  {
    get
    {
      int elementIdDPadUp;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*) &elementIdDPadUp);
      return elementIdDPadUp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*) &value);
    }
  }

  public static unsafe int elementId_dPadRight
  {
    get
    {
      int elementIdDPadRight;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*) &elementIdDPadRight);
      return elementIdDPadRight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*) &value);
    }
  }

  public static unsafe int elementId_dPadDown
  {
    get
    {
      int elementIdDPadDown;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*) &elementIdDPadDown);
      return elementIdDPadDown;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*) &value);
    }
  }

  public static unsafe int elementId_dPadLeft
  {
    get
    {
      int elementIdDPadLeft;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*) &elementIdDPadLeft);
      return elementIdDPadLeft;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*) &value);
    }
  }

  public static unsafe int elementId_dPad
  {
    get
    {
      int elementIdDPad;
      IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad, (void*) &elementIdDPad);
      return elementIdDPad;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad, (void*) &value);
    }
  }
}
