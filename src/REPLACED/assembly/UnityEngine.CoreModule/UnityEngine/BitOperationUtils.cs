// Decompiled with JetBrains decompiler
// Type: UnityEngine.BitOperationUtils
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

#nullable disable
namespace UnityEngine;

public static class BitOperationUtils
{
  public static int CountBits(int mask) => BitOperationUtils.CountBits((uint) mask);

  public static int CountBits(uint mask)
  {
    uint num = 0;
    for (; mask > 0U; mask >>= 1)
      num += mask & 1U;
    return (int) num;
  }

  public static bool IsValueWithinMaskedBitsRange(uint value, uint mask, int bitCount)
  {
    return BitOperationUtils.AnyBitMatch(mask, value) && BitOperationUtils.IsValueSmallerOrEqualThanIndex(value, BitOperationUtils.BitCountToIndex(bitCount));
  }

  public static uint ModifyMaskByValuesArrayAndBitCount(
    uint mask,
    IEnumerable<int> values,
    int bitCount = default (int))
  {
    BitOperationUtils.AssertBitCount(bitCount);
    uint num = 0;
    IEnumerator<int> enumerator = values.GetEnumerator();
    try
    {
      while (((IEnumerator) enumerator).MoveNext())
      {
        uint current = (uint) enumerator.Current;
        if (BitOperationUtils.IsValueWithinMaskedBitsRange(current, mask, bitCount))
          num += current;
      }
    }
    finally
    {
      ((IDisposable) enumerator)?.Dispose();
    }
    return num;
  }

  public static bool AreAllBitsSetForValues(uint mask, IEnumerable<int> values, int bitCount = default (int))
  {
    BitOperationUtils.AssertBitCount(bitCount);
    IEnumerator<int> enumerator = values.GetEnumerator();
    try
    {
      while (((IEnumerator) enumerator).MoveNext())
      {
        uint current = (uint) enumerator.Current;
        if (!BitOperationUtils.AnyBitMatch(mask, current) || BitOperationUtils.IsValueBiggerOrEqualThanIndex(current, BitOperationUtils.BitCountToIndex(bitCount)))
          return false;
      }
    }
    finally
    {
      ((IDisposable) enumerator)?.Dispose();
    }
    return true;
  }

  public static uint IndexToValue(int index)
  {
    BitOperationUtils.AssertIndex(index);
    return (uint) (1 << index);
  }

  public static bool IsValueSmallerThanIndex(uint value, int index)
  {
    BitOperationUtils.AssertIndex(index);
    return value < BitOperationUtils.IndexToValue(index);
  }

  public static bool IsValueBiggerThanIndex(uint value, int index)
  {
    BitOperationUtils.AssertIndex(index);
    return value > BitOperationUtils.IndexToValue(index);
  }

  public static bool IsValueSmallerOrEqualThanIndex(uint value, int index)
  {
    BitOperationUtils.AssertIndex(index);
    return value <= BitOperationUtils.IndexToValue(index);
  }

  public static bool IsValueBiggerOrEqualThanIndex(uint value, int index)
  {
    BitOperationUtils.AssertIndex(index);
    return value >= BitOperationUtils.IndexToValue(index);
  }

  public static bool AnyBitMatch(uint mask, uint value) => (mask & value) > 0U;

  public static int BitCountToIndex(int bitCount)
  {
    BitOperationUtils.AssertBitCount(bitCount);
    return bitCount - 1;
  }

  public static void AssertBitCount(int bitCount)
  {
    Debug.Assert(bitCount >= 1 && bitCount <= 32 /*0x20*/, "Bit count must be between 1 and 32.");
  }

  public static void AssertIndex(int index)
  {
    Debug.Assert(index >= 0 && index <= 31 /*0x1F*/, "Index must be between 0 and 31.");
  }
}
