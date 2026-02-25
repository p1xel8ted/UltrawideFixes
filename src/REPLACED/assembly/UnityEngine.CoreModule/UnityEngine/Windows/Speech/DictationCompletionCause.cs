// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Speech.DictationCompletionCause
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Windows.Speech;

public enum DictationCompletionCause
{
  Complete,
  AudioQualityFailure,
  Canceled,
  TimeoutExceeded,
  PauseLimitExceeded,
  NetworkFailure,
  MicrophoneUnavailable,
  UnknownError,
}
