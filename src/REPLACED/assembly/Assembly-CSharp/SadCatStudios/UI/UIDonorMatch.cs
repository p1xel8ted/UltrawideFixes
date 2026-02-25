// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIDonorMatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI;

public class UIDonorMatch(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nameList;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftText;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightText;
  private static readonly System.IntPtr NativeFieldInfoPtr_matchLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_matchRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_namesPerColumn;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_fullNameList;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftI;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightI;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelSource;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartRunning_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopRunning_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FillList_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLines_Private_UniTaskVoid_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIDonorMatch()
  {
    Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIDonorMatch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr);
    UIDonorMatch.NativeFieldInfoPtr_nameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (nameList));
    UIDonorMatch.NativeFieldInfoPtr_leftText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (leftText));
    UIDonorMatch.NativeFieldInfoPtr_rightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (rightText));
    UIDonorMatch.NativeFieldInfoPtr_matchLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (matchLeft));
    UIDonorMatch.NativeFieldInfoPtr_matchRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (matchRight));
    UIDonorMatch.NativeFieldInfoPtr_namesPerColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (namesPerColumn));
    UIDonorMatch.NativeFieldInfoPtr_scrollDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (scrollDelay));
    UIDonorMatch.NativeFieldInfoPtr_fullNameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (fullNameList));
    UIDonorMatch.NativeFieldInfoPtr_leftBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (leftBuilder));
    UIDonorMatch.NativeFieldInfoPtr_rightBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (rightBuilder));
    UIDonorMatch.NativeFieldInfoPtr_leftI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (leftI));
    UIDonorMatch.NativeFieldInfoPtr_rightI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (rightI));
    UIDonorMatch.NativeFieldInfoPtr_cancelSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, nameof (cancelSource));
    UIDonorMatch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672030);
    UIDonorMatch.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672031);
    UIDonorMatch.NativeMethodInfoPtr_StartRunning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672032);
    UIDonorMatch.NativeMethodInfoPtr_StopRunning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672033);
    UIDonorMatch.NativeMethodInfoPtr_FillList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672034);
    UIDonorMatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672035);
    UIDonorMatch.NativeMethodInfoPtr_UpdateLines_Private_UniTaskVoid_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672036);
    UIDonorMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, 100672037);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97516, XrefRangeEnd = 97523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97523, XrefRangeEnd = 97529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97529, XrefRangeEnd = 97544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_StartRunning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97544, XrefRangeEnd = 97550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_StopRunning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 97561, RefRangeEnd = 97563, XrefRangeStart = 97550, XrefRangeEnd = 97561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FillList()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_FillList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97563, XrefRangeEnd = 97565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97565, XrefRangeEnd = 97568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid UpdateLines(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr_UpdateLines_Private_UniTaskVoid_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97568, XrefRangeEnd = 97576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIDonorMatch()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDonorMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStringArray nameList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_nameList));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_nameList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text leftText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_leftText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_leftText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text rightText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_rightText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_rightText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform matchLeft
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_matchLeft));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_matchLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform matchRight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_matchRight));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_matchRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int namesPerColumn
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_namesPerColumn));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_namesPerColumn)) = value;
    }
  }

  public unsafe float scrollDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_scrollDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_scrollDelay)) = value;
    }
  }

  public unsafe string fullNameList
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_fullNameList)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_fullNameList), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe StringBuilder leftBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_leftBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_leftBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder rightBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_rightBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_rightBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int leftI
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_leftI));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_leftI)) = value;
    }
  }

  public unsafe int rightI
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_rightI));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_rightI)) = value;
    }
  }

  public unsafe CancellationTokenSource cancelSource
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_cancelSource));
      return num == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch.NativeFieldInfoPtr_cancelSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UIDonorMatch+<UpdateLines>d__19")]
  public sealed class _UpdateLines_d__19 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancel;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _UpdateLines_d__19()
    {
      Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDonorMatch>.NativeClassPtr, "<UpdateLines>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr);
      UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, "<>1__state");
      UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, "<>t__builder");
      UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, "<>4__this");
      UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, nameof (cancel));
      UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, "<>u__1");
      UIDonorMatch._UpdateLines_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, 100672038);
      UIDonorMatch._UpdateLines_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr, 100672039);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97488, XrefRangeEnd = 97516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDonorMatch._UpdateLines_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDonorMatch._UpdateLines_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _UpdateLines_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _UpdateLines_d__19()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDonorMatch._UpdateLines_d__19>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIDonorMatch __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIDonorMatch) null : Il2CppObjectPool.Get<UIDonorMatch>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CancellationToken cancel
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr_cancel);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr_cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDonorMatch._UpdateLines_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
