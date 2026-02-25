// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.Hacking.PipePuzzle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Environment.Hacking;

public class PipePuzzle(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_solvedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_puzzleInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_puzzleOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr_puzzleLines;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_puzzleActive;
  private static readonly System.IntPtr NativeFieldInfoPtr_puzzleSolved;
  private static readonly System.IntPtr NativeFieldInfoPtr_puzzleActivatedSound;
  private static readonly System.IntPtr NativeMethodInfoPtr_CoordsForSide_Private_Vector2Int_Vector2Int_WorkingSides_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActivatePuzzle_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPuzzle_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_Vector2Int_WorkingSides_0;

  static PipePuzzle()
  {
    Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment.Hacking", nameof (PipePuzzle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr);
    PipePuzzle.NativeFieldInfoPtr_solvedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (solvedEvent));
    PipePuzzle.NativeFieldInfoPtr_puzzleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (puzzleInput));
    PipePuzzle.NativeFieldInfoPtr_puzzleOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (puzzleOutput));
    PipePuzzle.NativeFieldInfoPtr_puzzleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (puzzleLines));
    PipePuzzle.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (saveData));
    PipePuzzle.NativeFieldInfoPtr_puzzleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (puzzleActive));
    PipePuzzle.NativeFieldInfoPtr_puzzleSolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (puzzleSolved));
    PipePuzzle.NativeFieldInfoPtr_puzzleActivatedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (puzzleActivatedSound));
    PipePuzzle.NativeMethodInfoPtr_CoordsForSide_Private_Vector2Int_Vector2Int_WorkingSides_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676241);
    PipePuzzle.NativeMethodInfoPtr_ActivatePuzzle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676242);
    PipePuzzle.NativeMethodInfoPtr_CheckPuzzle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676243);
    PipePuzzle.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676244);
    PipePuzzle.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676245);
    PipePuzzle.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676246);
    PipePuzzle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676247);
    PipePuzzle.NativeMethodInfoPtr_Method_Private_Boolean_Vector2Int_WorkingSides_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, 100676248);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 122155, RefRangeEnd = 122156, XrefRangeStart = 122152, XrefRangeEnd = 122155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2Int CoordsForSide(Vector2Int coords, PipePuzzlePart.WorkingSides side)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &coords;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &side;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_CoordsForSide_Private_Vector2Int_Vector2Int_WorkingSides_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122156, XrefRangeEnd = 122164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActivatePuzzle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_ActivatePuzzle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 122174, RefRangeEnd = 122177, XrefRangeStart = 122164, XrefRangeEnd = 122174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckPuzzle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_CheckPuzzle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122177, XrefRangeEnd = 122179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122179, XrefRangeEnd = 122180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122180, XrefRangeEnd = 122188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PipePuzzle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 122219, RefRangeEnd = 122221, XrefRangeStart = 122188, XrefRangeEnd = 122219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Method_Private_Boolean_Vector2Int_WorkingSides_0(
    Vector2Int pos,
    PipePuzzlePart.WorkingSides fromSide)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromSide;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzle.NativeMethodInfoPtr_Method_Private_Boolean_Vector2Int_WorkingSides_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe UnityEvent solvedEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_solvedEvent));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_solvedEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PipePuzzle.OutsidePipe puzzleInput
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleInput));
      return num == System.IntPtr.Zero ? (PipePuzzle.OutsidePipe) null : Il2CppObjectPool.Get<PipePuzzle.OutsidePipe>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleInput), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PipePuzzle.OutsidePipe puzzleOutput
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleOutput));
      return num == System.IntPtr.Zero ? (PipePuzzle.OutsidePipe) null : Il2CppObjectPool.Get<PipePuzzle.OutsidePipe>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleOutput), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppReferenceArray<PipePuzzlePart>> puzzleLines
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleLines));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppReferenceArray<PipePuzzlePart>>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<PipePuzzlePart>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleLines), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PipePuzzle.SaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (PipePuzzle.SaveData) null : Il2CppObjectPool.Get<PipePuzzle.SaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool puzzleActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleActive)) = value;
    }
  }

  public unsafe bool puzzleSolved
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleSolved));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleSolved)) = value;
    }
  }

  public unsafe EventReference puzzleActivatedSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleActivatedSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.NativeFieldInfoPtr_puzzleActivatedSound)) = value;
    }
  }

  [Serializable]
  public class OutsidePipe(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectsFromSide;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static OutsidePipe()
    {
      Il2CppClassPointerStore<PipePuzzle.OutsidePipe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (OutsidePipe));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PipePuzzle.OutsidePipe>.NativeClassPtr);
      PipePuzzle.OutsidePipe.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle.OutsidePipe>.NativeClassPtr, nameof (Position));
      PipePuzzle.OutsidePipe.NativeFieldInfoPtr_ConnectsFromSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle.OutsidePipe>.NativeClassPtr, nameof (ConnectsFromSide));
      PipePuzzle.OutsidePipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle.OutsidePipe>.NativeClassPtr, 100676249);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OutsidePipe()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PipePuzzle.OutsidePipe>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PipePuzzle.OutsidePipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector2Int Position
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.OutsidePipe.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.OutsidePipe.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe PipePuzzlePart.WorkingSides ConnectsFromSide
    {
      get
      {
        return *(PipePuzzlePart.WorkingSides*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.OutsidePipe.NativeFieldInfoPtr_ConnectsFromSide));
      }
      [param: In] set
      {
        *(PipePuzzlePart.WorkingSides*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.OutsidePipe.NativeFieldInfoPtr_ConnectsFromSide)) = value;
      }
    }
  }

  [Serializable]
  public class SaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PuzzleSolved;
    private static readonly System.IntPtr NativeFieldInfoPtr_PuzzleActive;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SaveData()
    {
      Il2CppClassPointerStore<PipePuzzle.SaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PipePuzzle>.NativeClassPtr, nameof (SaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PipePuzzle.SaveData>.NativeClassPtr);
      PipePuzzle.SaveData.NativeFieldInfoPtr_PuzzleSolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle.SaveData>.NativeClassPtr, nameof (PuzzleSolved));
      PipePuzzle.SaveData.NativeFieldInfoPtr_PuzzleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzle.SaveData>.NativeClassPtr, nameof (PuzzleActive));
      PipePuzzle.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzle.SaveData>.NativeClassPtr, 100676250);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PipePuzzle.SaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PipePuzzle.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool PuzzleSolved
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.SaveData.NativeFieldInfoPtr_PuzzleSolved));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.SaveData.NativeFieldInfoPtr_PuzzleSolved)) = value;
      }
    }

    public unsafe bool PuzzleActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.SaveData.NativeFieldInfoPtr_PuzzleActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzle.SaveData.NativeFieldInfoPtr_PuzzleActive)) = value;
      }
    }
  }
}
