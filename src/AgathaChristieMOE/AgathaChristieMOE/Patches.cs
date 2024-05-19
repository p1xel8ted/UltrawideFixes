namespace AgathaChristieMOE;

[Harmony]
public static class Patches
{
    private static ThirdPersonController ThirdPersonControllerInstance { get; set; }

    [HarmonyPostfix]
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashscreenStarter), nameof(SplashscreenStarter.Start))]
    public static void SplashscreenStarter_Constructor(SplashscreenStarter __instance)
    {
        __instance._bShowSplashscreen = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Prepare(VideoPlayer __instance)
    {
        if (__instance.name.Contains("Microids"))
        {
            __instance.playbackSpeed = 1000f;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Splashscreen), nameof(Splashscreen.Start))]
    public static void Splashscreen_Start(Splashscreen __instance)
    {
        __instance._fFadeIn = 0f;
        __instance._fFadeOut = 0f;
        __instance._fDuration = 0f;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ThirdPersonController), nameof(ThirdPersonController.SetCanRun))]
    public static void ThirdPersonController_SetCanRun(ThirdPersonController __instance, ref bool bCanRun)
    {
        if (!Plugin.AlwaysAllowedToRun.Value) return;

        bCanRun = true;
        __instance._bRunBlocked = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ThirdPersonController), nameof(ThirdPersonController.OnVariableChanged))]
    public static void ThirdPersonController_SetCanRun(ThirdPersonController __instance, int nVariable, bool bValue, bool bNotify)
    {
        if (Plugin.AlwaysAllowedToRun.Value)
        {
            __instance._bRunBlocked = false;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ThirdPersonController), nameof(ThirdPersonController.Update))]
    public static void ThirdPersonController_CalculateWalkRunSpeed(ThirdPersonController __instance)
    {
        ThirdPersonControllerInstance = __instance;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Animator), nameof(Animator.SetFloat), typeof(int), typeof(float))]
    public static void Animator_SetFloat(Animator __instance, ref int id, ref float value)
    {
        if (Plugin.MoveSpeed.Value <= 0) return;
        var tpInput = GameSingleton.gameSingleton.GetManager<InputManager>().GetInputEvents<ThirdPersonInputEvents>();
        if (ThirdPersonControllerInstance && id == ThirdPersonControllerInstance._nSpeedFloatAnimatorParameterID && (tpInput._movementAction.IsPressed() || tpInput._runAction.IsPressed()))
        {
            __instance.speed = 1 + 1 * (Plugin.MoveSpeed.Value / 100f);
            __instance.speed *= 2;
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CharacterController), nameof(CharacterController.Move))]
    public static void CharacterController_Move(CharacterController __instance, ref Vector3 motion)
    {
        if (Plugin.MoveSpeed.Value <= 0) return;
        var tpInput = GameSingleton.gameSingleton.GetManager<InputManager>().GetInputEvents<ThirdPersonInputEvents>();
        if (tpInput._movementAction.IsPressed() || tpInput._runAction.IsPressed())
        {
            motion += motion * (Plugin.MoveSpeed.Value / 100f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCameraBase), nameof(CinemachineVirtualCameraBase.Update))]
    public static void CinemachineVirtualCameraBase_OnEnable(ref CinemachineVirtualCameraBase __instance)
    {
        if (__instance is not CinemachineVirtualCamera cvc) return;
        cvc.m_Lens = cvc.m_Lens with {GateFit = Camera.GateFitMode.Vertical};
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ThirdPersonCamera), nameof(ThirdPersonCamera.ApplyFOV))]
    public static void ThirdPersonCamera_ApplyFOV(ref ThirdPersonCamera __instance)
    {
        var percent = Plugin.FoVMultiplierPercent.Value / 100f;
        __instance._cinemachineCamera.m_Lens.FieldOfView += __instance._cinemachineCamera.m_Lens.FieldOfView * percent;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}