// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.TransitToAIDecisionObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM;

public class TransitToAIDecisionObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_transitNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_aiController;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnter_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TransitToAIDecisionObject()
  {
    Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (TransitToAIDecisionObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr);
    TransitToAIDecisionObject.NativeFieldInfoPtr_transitNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr, nameof (transitNode));
    TransitToAIDecisionObject.NativeFieldInfoPtr_aiController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr, nameof (aiController));
    TransitToAIDecisionObject.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr, 100673306);
    TransitToAIDecisionObject.NativeMethodInfoPtr_OnEnter_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr, 100673307);
    TransitToAIDecisionObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr, 100673308);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109424, XrefRangeEnd = 109429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Init(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransitToAIDecisionObject.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109429, XrefRangeEnd = 109431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransitToAIDecisionObject.NativeMethodInfoPtr_OnEnter_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TransitToAIDecisionObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitToAIDecisionObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransitToAIDecisionObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TransitToAIDecision transitNode
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToAIDecisionObject.NativeFieldInfoPtr_transitNode));
      return num == System.IntPtr.Zero ? (TransitToAIDecision) null : Il2CppObjectPool.Get<TransitToAIDecision>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitToAIDecisionObject.NativeFieldInfoPtr_transitNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIController aiController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToAIDecisionObject.NativeFieldInfoPtr_aiController));
      return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitToAIDecisionObject.NativeFieldInfoPtr_aiController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
