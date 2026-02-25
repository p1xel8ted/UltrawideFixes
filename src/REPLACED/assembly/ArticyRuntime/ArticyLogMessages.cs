// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLogMessages
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public static class ArticyLogMessages : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MultiExportFilesWarning;
  private static readonly System.IntPtr NativeFieldInfoPtr_MultiExportFilesListFiles;
  private static readonly System.IntPtr NativeFieldInfoPtr_MultiExportFileUsingFirstFile;
  private static readonly System.IntPtr NativeFieldInfoPtr_ImportFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_ImportFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_RelocateGenerated;
  private static readonly System.IntPtr NativeFieldInfoPtr_ImportFileChangedDuringPlayMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_ObjectDefinitionChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_IncompatibleImportFile;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddressablesPackageNotSetUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_CouldNotParseError;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoLocaFilesFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_LocaFilesInDifferentFolderFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_DuplicateLocaId;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScriptFragmentsTypeNotAvailable;
  private static readonly System.IntPtr NativeFieldInfoPtr_GlobalVariablesTypeNotAvailable;
  private static readonly System.IntPtr NativeFieldInfoPtr_ObjectTypeNotAvailable;
  private static readonly System.IntPtr NativeFieldInfoPtr_CouldNotDeleteUnusedAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetAssetRefError;
  private static readonly System.IntPtr NativeFieldInfoPtr_CouldNotParseFeature;
  private static readonly System.IntPtr NativeFieldInfoPtr_UsedPropertyNotInObjectDefinition;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnhandledPropertyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_FeatureConstraintsIsNull;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoCSharpTypeFoundForArticyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_CouldNotAccessFileAfter10Tries;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExportFileWithoutEnumLocalizationWarning;
  private static readonly System.IntPtr NativeFieldInfoPtr_InvalidImportFileFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_PluginUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatingRuntimeSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatingNewSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatingNewEditorSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_MultipleSettingsAssetError;
  private static readonly System.IntPtr NativeFieldInfoPtr_MultipleSettingsAssetErrorUsingFirstFile;
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalRessourceLoaded;
  private static readonly System.IntPtr NativeFieldInfoPtr_MissingDllResource;
  private static readonly System.IntPtr NativeFieldInfoPtr_ObjectPickerDuringRecomplileError;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxObjectPickerResultsExceeded;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArticyCustomFilterAttributeMethodNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArticyCustomFilterCreatedDelegateFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArticyCustomFilterAttributeInvokeFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_GenerateStringInterpolationCodeHasChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddressablesHasChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyDefinitionsHasChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyDefinitionsNotSupported;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyDefinitionCreated;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyDefinitionDeleted;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyDefinitionInvalidFolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExecuteMethodErrorTypeNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExecuteMethodErrorMethodNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExecuteMethodErrorInvalidFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundFilterNoRepaintMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_TextureTypeError;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetAudioError;
  private static readonly System.IntPtr NativeFieldInfoPtr_RepairedAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnsupportedComponentError;
  private static readonly System.IntPtr NativeFieldInfoPtr_CloneEditTimeError;
  private static readonly System.IntPtr NativeFieldInfoPtr_CloneWithInstanceIdZeroError;
  private static readonly System.IntPtr NativeFieldInfoPtr_RecreateScriptFragmentsWarning;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScriptFragmentsTypeNotFoundError;
  private static readonly System.IntPtr NativeFieldInfoPtr_DatabaseLoadingError;
  private static readonly System.IntPtr NativeFieldInfoPtr_PackageNotFoundError;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoFlowPlayerCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_BranchIndexOutOfBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_FinishCurrentPausedObjectIndexOutOfBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_InfiniteLoopDetectionFlowPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_AbortedDueToInfiniteLoop;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowPlayerDetachedFromArticy;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnknownBranchSortType;
  private static readonly System.IntPtr NativeFieldInfoPtr_StringFormatLocalizedStringError;
  private static readonly System.IntPtr NativeFieldInfoPtr_CouldNotFindLanguage;
  private static readonly System.IntPtr NativeFieldInfoPtr_MissingLocalizationError;
  private static readonly System.IntPtr NativeFieldInfoPtr_LanguageFileNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_UsingUwpCompatibleWeakDelegates;
  private static readonly System.IntPtr NativeFieldInfoPtr_FailedDetectUwpUsage;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddListenerVariableNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoPropertiesFoundWithFilter;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoPropertiesOnArticyObjectFoundWithFilter;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoPropertiesForTypeFoundWithFilter;
  private static readonly System.IntPtr NativeFieldInfoPtr_TypeDoesNotSupportObjectNotfifications;
  private static readonly System.IntPtr NativeFieldInfoPtr_MethodProviderNotSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddOperatorFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_PropMethodFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_SeenCountersSetDuringForecasting;
  private static readonly System.IntPtr NativeFieldInfoPtr_FallbackNodeArgumentNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResetVariableFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResetVariableEditMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveInTokenError;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveInExpressionError;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReferenceStripAccessError;
  private static readonly System.IntPtr NativeFieldInfoPtr_StringFormatFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_StringFormatInfiniteLoopError;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveInfiniteLoopError;
  private static readonly System.IntPtr NativeFieldInfoPtr_AccessPropertyOnPropertyInfoError;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveStepLocalizeExpression;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveStepStringFormatRecursively;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveTokens;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveTokenSteps;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveDone;
  private static readonly System.IntPtr NativeFieldInfoPtr_MethodToRemoveDiffersFromCachedValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_EnumValueNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_PropertyNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_MethodNotAlive;
  private static readonly System.IntPtr NativeFieldInfoPtr_MethodNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_AnonymousMethodUsed;
  private static readonly System.IntPtr NativeFieldInfoPtr_TooFewArgumentsPassedToConditionMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_InvalidCondtionResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_ResolveVariableFailedButNamespaceFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_PropertyValueNotSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_SubtokenAfterScriptCall;
  private static readonly System.IntPtr NativeFieldInfoPtr_FromPropertyMalformedExpression;
  private static readonly System.IntPtr NativeFieldInfoPtr_LoadingTypeSystemFailed;
  private static readonly System.IntPtr NativeFieldInfoPtr_MoreThanOnePropForFilterFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_FiltersWithMoreThanOneDotError;
  private static readonly System.IntPtr NativeFieldInfoPtr_FeatureTypeNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_FeatureNotFoundOnObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_PropertyNotFoundOnFeature;
  private static readonly System.IntPtr NativeFieldInfoPtr_PropertyNotFoundOnArticyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_EnumValueNotFoundOnObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArticyTypeNotFound;
  private static readonly System.IntPtr NativeFieldInfoPtr_NoPropertiesFoundThatMatchesFilter;
  private static readonly System.IntPtr NativeFieldInfoPtr_CloningAtEditTimeInfo;

  static ArticyLogMessages()
  {
    Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLogMessages));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr);
    ArticyLogMessages.NativeFieldInfoPtr_MultiExportFilesWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MultiExportFilesWarning));
    ArticyLogMessages.NativeFieldInfoPtr_MultiExportFilesListFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MultiExportFilesListFiles));
    ArticyLogMessages.NativeFieldInfoPtr_MultiExportFileUsingFirstFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MultiExportFileUsingFirstFile));
    ArticyLogMessages.NativeFieldInfoPtr_ImportFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ImportFinished));
    ArticyLogMessages.NativeFieldInfoPtr_ImportFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ImportFailed));
    ArticyLogMessages.NativeFieldInfoPtr_RelocateGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (RelocateGenerated));
    ArticyLogMessages.NativeFieldInfoPtr_ImportFileChangedDuringPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ImportFileChangedDuringPlayMode));
    ArticyLogMessages.NativeFieldInfoPtr_ObjectDefinitionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ObjectDefinitionChanged));
    ArticyLogMessages.NativeFieldInfoPtr_IncompatibleImportFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (IncompatibleImportFile));
    ArticyLogMessages.NativeFieldInfoPtr_AddressablesPackageNotSetUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AddressablesPackageNotSetUp));
    ArticyLogMessages.NativeFieldInfoPtr_CouldNotParseError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CouldNotParseError));
    ArticyLogMessages.NativeFieldInfoPtr_NoLocaFilesFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoLocaFilesFound));
    ArticyLogMessages.NativeFieldInfoPtr_LocaFilesInDifferentFolderFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (LocaFilesInDifferentFolderFound));
    ArticyLogMessages.NativeFieldInfoPtr_DuplicateLocaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (DuplicateLocaId));
    ArticyLogMessages.NativeFieldInfoPtr_ScriptFragmentsTypeNotAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ScriptFragmentsTypeNotAvailable));
    ArticyLogMessages.NativeFieldInfoPtr_GlobalVariablesTypeNotAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (GlobalVariablesTypeNotAvailable));
    ArticyLogMessages.NativeFieldInfoPtr_ObjectTypeNotAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ObjectTypeNotAvailable));
    ArticyLogMessages.NativeFieldInfoPtr_CouldNotDeleteUnusedAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CouldNotDeleteUnusedAsset));
    ArticyLogMessages.NativeFieldInfoPtr_SetAssetRefError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (SetAssetRefError));
    ArticyLogMessages.NativeFieldInfoPtr_CouldNotParseFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CouldNotParseFeature));
    ArticyLogMessages.NativeFieldInfoPtr_UsedPropertyNotInObjectDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (UsedPropertyNotInObjectDefinition));
    ArticyLogMessages.NativeFieldInfoPtr_UnhandledPropertyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (UnhandledPropertyType));
    ArticyLogMessages.NativeFieldInfoPtr_FeatureConstraintsIsNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FeatureConstraintsIsNull));
    ArticyLogMessages.NativeFieldInfoPtr_NoCSharpTypeFoundForArticyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoCSharpTypeFoundForArticyType));
    ArticyLogMessages.NativeFieldInfoPtr_CouldNotAccessFileAfter10Tries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CouldNotAccessFileAfter10Tries));
    ArticyLogMessages.NativeFieldInfoPtr_ExportFileWithoutEnumLocalizationWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ExportFileWithoutEnumLocalizationWarning));
    ArticyLogMessages.NativeFieldInfoPtr_InvalidImportFileFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (InvalidImportFileFormat));
    ArticyLogMessages.NativeFieldInfoPtr_PluginUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PluginUpdated));
    ArticyLogMessages.NativeFieldInfoPtr_CreatingRuntimeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CreatingRuntimeSettings));
    ArticyLogMessages.NativeFieldInfoPtr_CreatingNewSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CreatingNewSettings));
    ArticyLogMessages.NativeFieldInfoPtr_CreatingNewEditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CreatingNewEditorSettings));
    ArticyLogMessages.NativeFieldInfoPtr_MultipleSettingsAssetError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MultipleSettingsAssetError));
    ArticyLogMessages.NativeFieldInfoPtr_MultipleSettingsAssetErrorUsingFirstFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MultipleSettingsAssetErrorUsingFirstFile));
    ArticyLogMessages.NativeFieldInfoPtr_LocalRessourceLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (LocalRessourceLoaded));
    ArticyLogMessages.NativeFieldInfoPtr_MissingDllResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MissingDllResource));
    ArticyLogMessages.NativeFieldInfoPtr_ObjectPickerDuringRecomplileError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ObjectPickerDuringRecomplileError));
    ArticyLogMessages.NativeFieldInfoPtr_MaxObjectPickerResultsExceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MaxObjectPickerResultsExceeded));
    ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterAttributeMethodNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ArticyCustomFilterAttributeMethodNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterCreatedDelegateFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ArticyCustomFilterCreatedDelegateFailed));
    ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterAttributeInvokeFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ArticyCustomFilterAttributeInvokeFailed));
    ArticyLogMessages.NativeFieldInfoPtr_GenerateStringInterpolationCodeHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (GenerateStringInterpolationCodeHasChanged));
    ArticyLogMessages.NativeFieldInfoPtr_AddressablesHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AddressablesHasChanged));
    ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionsHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AssemblyDefinitionsHasChanged));
    ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionsNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AssemblyDefinitionsNotSupported));
    ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AssemblyDefinitionCreated));
    ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AssemblyDefinitionDeleted));
    ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionInvalidFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AssemblyDefinitionInvalidFolder));
    ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorTypeNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ExecuteMethodErrorTypeNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorMethodNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ExecuteMethodErrorMethodNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorInvalidFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ExecuteMethodErrorInvalidFormat));
    ArticyLogMessages.NativeFieldInfoPtr_BackgroundFilterNoRepaintMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (BackgroundFilterNoRepaintMethod));
    ArticyLogMessages.NativeFieldInfoPtr_TextureTypeError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (TextureTypeError));
    ArticyLogMessages.NativeFieldInfoPtr_SetAudioError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (SetAudioError));
    ArticyLogMessages.NativeFieldInfoPtr_RepairedAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (RepairedAsset));
    ArticyLogMessages.NativeFieldInfoPtr_UnsupportedComponentError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (UnsupportedComponentError));
    ArticyLogMessages.NativeFieldInfoPtr_CloneEditTimeError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CloneEditTimeError));
    ArticyLogMessages.NativeFieldInfoPtr_CloneWithInstanceIdZeroError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CloneWithInstanceIdZeroError));
    ArticyLogMessages.NativeFieldInfoPtr_RecreateScriptFragmentsWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (RecreateScriptFragmentsWarning));
    ArticyLogMessages.NativeFieldInfoPtr_ScriptFragmentsTypeNotFoundError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ScriptFragmentsTypeNotFoundError));
    ArticyLogMessages.NativeFieldInfoPtr_DatabaseLoadingError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (DatabaseLoadingError));
    ArticyLogMessages.NativeFieldInfoPtr_PackageNotFoundError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PackageNotFoundError));
    ArticyLogMessages.NativeFieldInfoPtr_NoFlowPlayerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoFlowPlayerCallback));
    ArticyLogMessages.NativeFieldInfoPtr_BranchIndexOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (BranchIndexOutOfBounds));
    ArticyLogMessages.NativeFieldInfoPtr_FinishCurrentPausedObjectIndexOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FinishCurrentPausedObjectIndexOutOfBounds));
    ArticyLogMessages.NativeFieldInfoPtr_InfiniteLoopDetectionFlowPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (InfiniteLoopDetectionFlowPlayer));
    ArticyLogMessages.NativeFieldInfoPtr_AbortedDueToInfiniteLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AbortedDueToInfiniteLoop));
    ArticyLogMessages.NativeFieldInfoPtr_FlowPlayerDetachedFromArticy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FlowPlayerDetachedFromArticy));
    ArticyLogMessages.NativeFieldInfoPtr_UnknownBranchSortType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (UnknownBranchSortType));
    ArticyLogMessages.NativeFieldInfoPtr_StringFormatLocalizedStringError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (StringFormatLocalizedStringError));
    ArticyLogMessages.NativeFieldInfoPtr_CouldNotFindLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CouldNotFindLanguage));
    ArticyLogMessages.NativeFieldInfoPtr_MissingLocalizationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MissingLocalizationError));
    ArticyLogMessages.NativeFieldInfoPtr_LanguageFileNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (LanguageFileNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_UsingUwpCompatibleWeakDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (UsingUwpCompatibleWeakDelegates));
    ArticyLogMessages.NativeFieldInfoPtr_FailedDetectUwpUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FailedDetectUwpUsage));
    ArticyLogMessages.NativeFieldInfoPtr_AddListenerVariableNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AddListenerVariableNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesFoundWithFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoPropertiesFoundWithFilter));
    ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesOnArticyObjectFoundWithFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoPropertiesOnArticyObjectFoundWithFilter));
    ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesForTypeFoundWithFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoPropertiesForTypeFoundWithFilter));
    ArticyLogMessages.NativeFieldInfoPtr_TypeDoesNotSupportObjectNotfifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (TypeDoesNotSupportObjectNotfifications));
    ArticyLogMessages.NativeFieldInfoPtr_MethodProviderNotSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MethodProviderNotSet));
    ArticyLogMessages.NativeFieldInfoPtr_AddOperatorFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AddOperatorFailed));
    ArticyLogMessages.NativeFieldInfoPtr_PropMethodFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PropMethodFailed));
    ArticyLogMessages.NativeFieldInfoPtr_SeenCountersSetDuringForecasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (SeenCountersSetDuringForecasting));
    ArticyLogMessages.NativeFieldInfoPtr_FallbackNodeArgumentNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FallbackNodeArgumentNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_ResetVariableFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResetVariableFailed));
    ArticyLogMessages.NativeFieldInfoPtr_ResetVariableEditMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResetVariableEditMode));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveInTokenError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveInTokenError));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveInExpressionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveInExpressionError));
    ArticyLogMessages.NativeFieldInfoPtr_ReferenceStripAccessError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ReferenceStripAccessError));
    ArticyLogMessages.NativeFieldInfoPtr_StringFormatFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (StringFormatFailed));
    ArticyLogMessages.NativeFieldInfoPtr_StringFormatInfiniteLoopError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (StringFormatInfiniteLoopError));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveInfiniteLoopError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveInfiniteLoopError));
    ArticyLogMessages.NativeFieldInfoPtr_AccessPropertyOnPropertyInfoError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AccessPropertyOnPropertyInfoError));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveStart));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveStepLocalizeExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveStepLocalizeExpression));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveStepStringFormatRecursively = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveStepStringFormatRecursively));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveTokens));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveTokenSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveTokenSteps));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveDone));
    ArticyLogMessages.NativeFieldInfoPtr_MethodToRemoveDiffersFromCachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MethodToRemoveDiffersFromCachedValue));
    ArticyLogMessages.NativeFieldInfoPtr_EnumValueNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (EnumValueNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PropertyNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_MethodNotAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MethodNotAlive));
    ArticyLogMessages.NativeFieldInfoPtr_MethodNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MethodNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_AnonymousMethodUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (AnonymousMethodUsed));
    ArticyLogMessages.NativeFieldInfoPtr_TooFewArgumentsPassedToConditionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (TooFewArgumentsPassedToConditionMethod));
    ArticyLogMessages.NativeFieldInfoPtr_InvalidCondtionResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (InvalidCondtionResult));
    ArticyLogMessages.NativeFieldInfoPtr_ResolveVariableFailedButNamespaceFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ResolveVariableFailedButNamespaceFound));
    ArticyLogMessages.NativeFieldInfoPtr_PropertyValueNotSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PropertyValueNotSet));
    ArticyLogMessages.NativeFieldInfoPtr_SubtokenAfterScriptCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (SubtokenAfterScriptCall));
    ArticyLogMessages.NativeFieldInfoPtr_FromPropertyMalformedExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FromPropertyMalformedExpression));
    ArticyLogMessages.NativeFieldInfoPtr_LoadingTypeSystemFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (LoadingTypeSystemFailed));
    ArticyLogMessages.NativeFieldInfoPtr_MoreThanOnePropForFilterFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (MoreThanOnePropForFilterFound));
    ArticyLogMessages.NativeFieldInfoPtr_FiltersWithMoreThanOneDotError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FiltersWithMoreThanOneDotError));
    ArticyLogMessages.NativeFieldInfoPtr_FeatureTypeNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FeatureTypeNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_FeatureNotFoundOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (FeatureNotFoundOnObject));
    ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFoundOnFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PropertyNotFoundOnFeature));
    ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFoundOnArticyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (PropertyNotFoundOnArticyType));
    ArticyLogMessages.NativeFieldInfoPtr_EnumValueNotFoundOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (EnumValueNotFoundOnObject));
    ArticyLogMessages.NativeFieldInfoPtr_ArticyTypeNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (ArticyTypeNotFound));
    ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesFoundThatMatchesFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (NoPropertiesFoundThatMatchesFilter));
    ArticyLogMessages.NativeFieldInfoPtr_CloningAtEditTimeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogMessages>.NativeClassPtr, nameof (CloningAtEditTimeInfo));
  }

  public ArticyLogMessages(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string MultiExportFilesWarning
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MultiExportFilesWarning, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MultiExportFilesWarning, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MultiExportFilesListFiles
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MultiExportFilesListFiles, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MultiExportFilesListFiles, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MultiExportFileUsingFirstFile
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MultiExportFileUsingFirstFile, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MultiExportFileUsingFirstFile, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ImportFinished
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ImportFinished, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ImportFinished, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ImportFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ImportFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ImportFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string RelocateGenerated
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_RelocateGenerated, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_RelocateGenerated, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ImportFileChangedDuringPlayMode
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ImportFileChangedDuringPlayMode, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ImportFileChangedDuringPlayMode, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ObjectDefinitionChanged
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ObjectDefinitionChanged, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ObjectDefinitionChanged, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string IncompatibleImportFile
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_IncompatibleImportFile, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_IncompatibleImportFile, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AddressablesPackageNotSetUp
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AddressablesPackageNotSetUp, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AddressablesPackageNotSetUp, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CouldNotParseError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotParseError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotParseError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoLocaFilesFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoLocaFilesFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoLocaFilesFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string LocaFilesInDifferentFolderFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_LocaFilesInDifferentFolderFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_LocaFilesInDifferentFolderFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string DuplicateLocaId
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_DuplicateLocaId, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_DuplicateLocaId, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ScriptFragmentsTypeNotAvailable
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ScriptFragmentsTypeNotAvailable, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ScriptFragmentsTypeNotAvailable, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string GlobalVariablesTypeNotAvailable
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_GlobalVariablesTypeNotAvailable, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_GlobalVariablesTypeNotAvailable, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ObjectTypeNotAvailable
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ObjectTypeNotAvailable, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ObjectTypeNotAvailable, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CouldNotDeleteUnusedAsset
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotDeleteUnusedAsset, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotDeleteUnusedAsset, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SetAssetRefError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_SetAssetRefError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_SetAssetRefError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CouldNotParseFeature
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotParseFeature, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotParseFeature, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string UsedPropertyNotInObjectDefinition
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_UsedPropertyNotInObjectDefinition, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_UsedPropertyNotInObjectDefinition, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string UnhandledPropertyType
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_UnhandledPropertyType, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_UnhandledPropertyType, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FeatureConstraintsIsNull
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FeatureConstraintsIsNull, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FeatureConstraintsIsNull, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoCSharpTypeFoundForArticyType
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoCSharpTypeFoundForArticyType, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoCSharpTypeFoundForArticyType, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CouldNotAccessFileAfter10Tries
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotAccessFileAfter10Tries, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotAccessFileAfter10Tries, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ExportFileWithoutEnumLocalizationWarning
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ExportFileWithoutEnumLocalizationWarning, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ExportFileWithoutEnumLocalizationWarning, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string InvalidImportFileFormat
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_InvalidImportFileFormat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_InvalidImportFileFormat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PluginUpdated
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PluginUpdated, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PluginUpdated, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CreatingRuntimeSettings
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CreatingRuntimeSettings, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CreatingRuntimeSettings, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CreatingNewSettings
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CreatingNewSettings, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CreatingNewSettings, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CreatingNewEditorSettings
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CreatingNewEditorSettings, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CreatingNewEditorSettings, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MultipleSettingsAssetError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MultipleSettingsAssetError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MultipleSettingsAssetError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MultipleSettingsAssetErrorUsingFirstFile
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MultipleSettingsAssetErrorUsingFirstFile, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MultipleSettingsAssetErrorUsingFirstFile, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string LocalRessourceLoaded
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_LocalRessourceLoaded, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_LocalRessourceLoaded, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MissingDllResource
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MissingDllResource, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MissingDllResource, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ObjectPickerDuringRecomplileError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ObjectPickerDuringRecomplileError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ObjectPickerDuringRecomplileError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MaxObjectPickerResultsExceeded
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MaxObjectPickerResultsExceeded, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MaxObjectPickerResultsExceeded, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ArticyCustomFilterAttributeMethodNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterAttributeMethodNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterAttributeMethodNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ArticyCustomFilterCreatedDelegateFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterCreatedDelegateFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterCreatedDelegateFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ArticyCustomFilterAttributeInvokeFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterAttributeInvokeFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyCustomFilterAttributeInvokeFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string GenerateStringInterpolationCodeHasChanged
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_GenerateStringInterpolationCodeHasChanged, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_GenerateStringInterpolationCodeHasChanged, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AddressablesHasChanged
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AddressablesHasChanged, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AddressablesHasChanged, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AssemblyDefinitionsHasChanged
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionsHasChanged, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionsHasChanged, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AssemblyDefinitionsNotSupported
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionsNotSupported, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionsNotSupported, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AssemblyDefinitionCreated
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionCreated, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionCreated, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AssemblyDefinitionDeleted
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionDeleted, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionDeleted, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AssemblyDefinitionInvalidFolder
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionInvalidFolder, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AssemblyDefinitionInvalidFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ExecuteMethodErrorTypeNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorTypeNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorTypeNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ExecuteMethodErrorMethodNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorMethodNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorMethodNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ExecuteMethodErrorInvalidFormat
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorInvalidFormat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ExecuteMethodErrorInvalidFormat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string BackgroundFilterNoRepaintMethod
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_BackgroundFilterNoRepaintMethod, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_BackgroundFilterNoRepaintMethod, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string TextureTypeError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_TextureTypeError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_TextureTypeError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SetAudioError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_SetAudioError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_SetAudioError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string RepairedAsset
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_RepairedAsset, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_RepairedAsset, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string UnsupportedComponentError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_UnsupportedComponentError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_UnsupportedComponentError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CloneEditTimeError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CloneEditTimeError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CloneEditTimeError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CloneWithInstanceIdZeroError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CloneWithInstanceIdZeroError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CloneWithInstanceIdZeroError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string RecreateScriptFragmentsWarning
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_RecreateScriptFragmentsWarning, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_RecreateScriptFragmentsWarning, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ScriptFragmentsTypeNotFoundError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ScriptFragmentsTypeNotFoundError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ScriptFragmentsTypeNotFoundError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string DatabaseLoadingError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_DatabaseLoadingError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_DatabaseLoadingError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PackageNotFoundError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PackageNotFoundError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PackageNotFoundError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoFlowPlayerCallback
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoFlowPlayerCallback, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoFlowPlayerCallback, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string BranchIndexOutOfBounds
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_BranchIndexOutOfBounds, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_BranchIndexOutOfBounds, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FinishCurrentPausedObjectIndexOutOfBounds
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FinishCurrentPausedObjectIndexOutOfBounds, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FinishCurrentPausedObjectIndexOutOfBounds, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string InfiniteLoopDetectionFlowPlayer
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_InfiniteLoopDetectionFlowPlayer, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_InfiniteLoopDetectionFlowPlayer, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AbortedDueToInfiniteLoop
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AbortedDueToInfiniteLoop, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AbortedDueToInfiniteLoop, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FlowPlayerDetachedFromArticy
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FlowPlayerDetachedFromArticy, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FlowPlayerDetachedFromArticy, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string UnknownBranchSortType
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_UnknownBranchSortType, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_UnknownBranchSortType, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string StringFormatLocalizedStringError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_StringFormatLocalizedStringError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_StringFormatLocalizedStringError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CouldNotFindLanguage
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotFindLanguage, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CouldNotFindLanguage, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MissingLocalizationError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MissingLocalizationError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MissingLocalizationError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string LanguageFileNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_LanguageFileNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_LanguageFileNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string UsingUwpCompatibleWeakDelegates
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_UsingUwpCompatibleWeakDelegates, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_UsingUwpCompatibleWeakDelegates, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FailedDetectUwpUsage
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FailedDetectUwpUsage, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FailedDetectUwpUsage, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AddListenerVariableNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AddListenerVariableNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AddListenerVariableNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoPropertiesFoundWithFilter
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesFoundWithFilter, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesFoundWithFilter, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoPropertiesOnArticyObjectFoundWithFilter
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesOnArticyObjectFoundWithFilter, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesOnArticyObjectFoundWithFilter, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoPropertiesForTypeFoundWithFilter
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesForTypeFoundWithFilter, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesForTypeFoundWithFilter, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string TypeDoesNotSupportObjectNotfifications
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_TypeDoesNotSupportObjectNotfifications, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_TypeDoesNotSupportObjectNotfifications, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MethodProviderNotSet
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MethodProviderNotSet, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MethodProviderNotSet, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AddOperatorFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AddOperatorFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AddOperatorFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PropMethodFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PropMethodFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PropMethodFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SeenCountersSetDuringForecasting
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_SeenCountersSetDuringForecasting, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_SeenCountersSetDuringForecasting, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FallbackNodeArgumentNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FallbackNodeArgumentNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FallbackNodeArgumentNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResetVariableFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResetVariableFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResetVariableFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResetVariableEditMode
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResetVariableEditMode, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResetVariableEditMode, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveInTokenError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveInTokenError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveInTokenError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveInExpressionError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveInExpressionError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveInExpressionError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ReferenceStripAccessError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ReferenceStripAccessError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ReferenceStripAccessError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string StringFormatFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_StringFormatFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_StringFormatFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string StringFormatInfiniteLoopError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_StringFormatInfiniteLoopError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_StringFormatInfiniteLoopError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveInfiniteLoopError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveInfiniteLoopError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveInfiniteLoopError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AccessPropertyOnPropertyInfoError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AccessPropertyOnPropertyInfoError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AccessPropertyOnPropertyInfoError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveStart
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveStart, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveStart, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveStepLocalizeExpression
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveStepLocalizeExpression, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveStepLocalizeExpression, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveStepStringFormatRecursively
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveStepStringFormatRecursively, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveStepStringFormatRecursively, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveTokens
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveTokens, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveTokens, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveTokenSteps
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveTokenSteps, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveTokenSteps, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveDone
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveDone, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveDone, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MethodToRemoveDiffersFromCachedValue
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MethodToRemoveDiffersFromCachedValue, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MethodToRemoveDiffersFromCachedValue, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string EnumValueNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_EnumValueNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_EnumValueNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PropertyNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MethodNotAlive
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MethodNotAlive, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MethodNotAlive, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MethodNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MethodNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MethodNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string AnonymousMethodUsed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_AnonymousMethodUsed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_AnonymousMethodUsed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string TooFewArgumentsPassedToConditionMethod
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_TooFewArgumentsPassedToConditionMethod, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_TooFewArgumentsPassedToConditionMethod, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string InvalidCondtionResult
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_InvalidCondtionResult, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_InvalidCondtionResult, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ResolveVariableFailedButNamespaceFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveVariableFailedButNamespaceFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ResolveVariableFailedButNamespaceFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PropertyValueNotSet
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyValueNotSet, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyValueNotSet, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SubtokenAfterScriptCall
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_SubtokenAfterScriptCall, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_SubtokenAfterScriptCall, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FromPropertyMalformedExpression
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FromPropertyMalformedExpression, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FromPropertyMalformedExpression, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string LoadingTypeSystemFailed
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_LoadingTypeSystemFailed, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_LoadingTypeSystemFailed, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string MoreThanOnePropForFilterFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_MoreThanOnePropForFilterFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_MoreThanOnePropForFilterFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FiltersWithMoreThanOneDotError
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FiltersWithMoreThanOneDotError, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FiltersWithMoreThanOneDotError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FeatureTypeNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FeatureTypeNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FeatureTypeNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string FeatureNotFoundOnObject
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_FeatureNotFoundOnObject, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_FeatureNotFoundOnObject, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PropertyNotFoundOnFeature
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFoundOnFeature, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFoundOnFeature, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PropertyNotFoundOnArticyType
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFoundOnArticyType, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_PropertyNotFoundOnArticyType, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string EnumValueNotFoundOnObject
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_EnumValueNotFoundOnObject, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_EnumValueNotFoundOnObject, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ArticyTypeNotFound
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyTypeNotFound, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_ArticyTypeNotFound, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string NoPropertiesFoundThatMatchesFilter
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesFoundThatMatchesFilter, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_NoPropertiesFoundThatMatchesFilter, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CloningAtEditTimeInfo
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyLogMessages.NativeFieldInfoPtr_CloningAtEditTimeInfo, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLogMessages.NativeFieldInfoPtr_CloningAtEditTimeInfo, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
