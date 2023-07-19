using System;
using HarmonyLib;
using MoonlighterUltrawide.Utilities;
using UnityEngine;

namespace MoonlighterUltrawide.Patches;

[HarmonyPatch]
public static class DungeonPatches
{
    private const float BaseAspectRatio = 16f / 9f;
    private const float DoorCorrectionPercentage = 0.015f;
    private static float PlayerAspectRatio { get; set; }
    private static float ScaleFactor { get; set; }


    //in case user changes resolution
    private static void UpdateAspectValues()
    {
        PlayerAspectRatio = (float) Screen.width / Screen.height;
        ScaleFactor = PlayerAspectRatio / BaseAspectRatio;
    }

    private static bool IsUltrawide()
    {
        UpdateAspectValues();
        return PlayerAspectRatio > BaseAspectRatio && Plugin.CorrectDungeons.Value && Plugin.UltrawideFixes.Value;
    }

    private static float GetAdjustedLeftDoorPosition(float baseDoorPosition)
    {
        var pos = Mathf.Abs(baseDoorPosition);
        UpdateAspectValues();
        var offset = pos * (ScaleFactor - 1f);
        var leftPosition = -pos - offset;
        leftPosition *= 1 - DoorCorrectionPercentage;
        return leftPosition;
    }

    private static float GetAdjustedRightDoorPosition(float baseDoorPosition)
    {
        var pos = Mathf.Abs(baseDoorPosition);
        UpdateAspectValues();
        var offset = pos * (ScaleFactor - 1f);
        var rightPosition = pos + offset;
        rightPosition *= 1 - DoorCorrectionPercentage;
        return rightPosition;
    }


    private static float GetAdjustedLeftPosition(float basePosition)
    {
        UpdateAspectValues();
        var offset = basePosition * (ScaleFactor - 1f);
        var leftPosition = -basePosition - offset;
        return leftPosition;
    }

    private static float GetAdjustedRightPosition(float basePosition)
    {
        UpdateAspectValues();
        var offset = basePosition * (ScaleFactor - 1f);
        var rightPosition = basePosition + offset;
        return rightPosition;
    }

    private static void UpdateSpecialDoorPosition(DungeonDoor door)
    {
        if (!IsUltrawide()) return;

        if (door != null)
        {
            var t = door.transform;
            if (TransformIsRightAngled(t))
            {
                if (TransformIsLeftSide(t))
                {
                    UpdateDoorPosition(door, Plugin.FinalLeftDoorPosition, GetAdjustedLeftDoorPosition);
                    UpdateDoorEntryPosition(door, Plugin.FinalLeftDoorEntryPosition);
                }

                if (TransformIsRightSide(t))
                {
                    UpdateDoorPosition(door, Plugin.FinalRightDoorPosition, GetAdjustedRightDoorPosition);
                    UpdateDoorEntryPosition(door, Plugin.FinalRightDoorEntryPosition);
                }
            }
        }
    }
    
    private static void UpdateXLevelDoorPosition(DungeonLastLevelDoor door)
    {
        if (!IsUltrawide()) return;

        if (door != null)
        {
            var t = door.transform;
            if (TransformIsRightAngled(t))
            {
                if (TransformIsLeftSide(t))
                {
                    UpdateDoorPosition(door, Plugin.FinalLeftDoorPosition, GetAdjustedLeftDoorPosition);
                }

                if (TransformIsRightSide(t))
                {
                    UpdateDoorPosition(door, Plugin.FinalRightDoorPosition, GetAdjustedRightDoorPosition);
                }
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(NextLevelDoor), nameof(NextLevelDoor.Init))]
    public static void NextLevelDoor_Init(ref NextLevelDoor __instance)
    {
        if (!IsUltrawide()) return;
        UpdateSpecialDoorPosition(__instance);
    }


    private static bool TransformIsRightAngled(Transform transform)
    {
        var zRotation = Mathf.Abs(transform.localEulerAngles.z % 360);
        return Mathf.Abs(zRotation - 90) <= 0.01 || Mathf.Abs(zRotation - 270) <= 0.01;
    }

    private static bool TransformIsLeftSide(Transform transform)
    {
        return transform.localPosition.x < 0;
    }

    private static bool TransformIsRightSide(Transform transform)
    {
        return transform.localPosition.x > 0;
    }

    private static void UpdateFloorWidth(DungeonRoom dungeonRoom)
    {
        if (!IsUltrawide()) return;
        
        if (dungeonRoom is DungeonBossRoom)
        {
            Plugin.LOG.LogWarning("DungeonBossRoom: Aborting UpdateFloorWidth");
            return;
        }
        
        UpdateAspectValues();
        var newFloorWidth = Mathf.RoundToInt(484 * ScaleFactor);
        dungeonRoom.roomFloorWidth = newFloorWidth;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.EnterRoom))]
    public static void DungeonRoom_EnterRoom(ref DungeonRoom __instance)
    {
        if (!IsUltrawide()) return;
        
        if (__instance is DungeonBossRoom)
        {
            Plugin.LOG.LogWarning("DungeonBossRoom: Aborting UpdateDoorPosition");
            return;
        }

        UpdateSpecialDoorPosition(__instance.specialDoor);

        UpdateDoorPosition(__instance.GetWestDoor(), Plugin.FinalLeftDoorPosition, GetAdjustedLeftDoorPosition);
        UpdateDoorPosition(__instance.GetEastDoor(), Plugin.FinalRightDoorPosition, GetAdjustedRightDoorPosition);
        UpdateDoorEntryPosition(__instance.GetWestDoor(), Plugin.FinalLeftDoorEntryPosition);
        UpdateDoorEntryPosition(__instance.GetEastDoor(), Plugin.FinalRightDoorEntryPosition);


        
        UpdateXLevelDoorPosition(__instance.lastLevelDoor);
        UpdateXLevelDoorPosition(__instance.firstLevelDoor);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonDoor), nameof(DungeonDoor.Start))]
    public static void DungeonDoor_Start(ref DungeonDoor __instance)
    {
        if (!IsUltrawide()) return;

        switch (__instance.name)
        {
            case "LevelDoorLeft":
                UpdateDoorPosition(__instance, Plugin.FinalLeftDoorPosition, GetAdjustedLeftDoorPosition);
                UpdateDoorEntryPosition(__instance, Plugin.FinalLeftDoorEntryPosition);
                break;

            case "LevelDoorRight":
                UpdateDoorPosition(__instance, Plugin.FinalRightDoorPosition, GetAdjustedRightDoorPosition);
                UpdateDoorEntryPosition(__instance, Plugin.FinalRightDoorEntryPosition);
                break;
        }
    }

    
    private static void UpdateDoorPosition(DungeonLastLevelDoor door, WriteOnce<float> finalDoorPosition, Func<float, float> getAdjustedPosition)
    {
        if (door == null) return;

        if (finalDoorPosition.HasValue)
        {
            door.transform.localPosition = new Vector3(finalDoorPosition.Value, 0f, 0f);
        }
        else
        {
            var newX = getAdjustedPosition(door.transform.localPosition.x);
            door.transform.localPosition = new Vector3(newX, 0f, 0f);

            finalDoorPosition.Value = newX;
        }
    }
    
    private static void UpdateDoorPosition(DungeonDoor door, WriteOnce<float> finalDoorPosition, Func<float, float> getAdjustedPosition)
    {
        if (door == null) return;

        if (finalDoorPosition.HasValue)
        {
            door.transform.localPosition = new Vector3(finalDoorPosition.Value, 0f, 0f);
        }
        else
        {
            var newX = getAdjustedPosition(door.transform.localPosition.x);
            door.transform.localPosition = new Vector3(newX, 0f, 0f);

            finalDoorPosition.Value = newX;
        }
    }

    private static void UpdateDoorEntryPosition(DungeonDoor door, WriteOnce<float> finalDoorEntryPosition)
    {
        if (door == null || door.playerEnterDestinyRoomPoint == null) return;

        if (finalDoorEntryPosition.HasValue)
        {
            door.playerEnterDestinyRoomPoint.localPosition = new Vector3(finalDoorEntryPosition.Value, 0f, 0f);
        }
        else
        {
            var newX = door.playerEnterDestinyRoomPoint.localPosition.x * ScaleFactor;
            door.playerEnterDestinyRoomPoint.localPosition = new Vector3(newX, 0f, 0f);

            finalDoorEntryPosition.Value = newX;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.FillRoomWithBreakables))]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.FillRoomWithCreatures))]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.FillRoomWithSprites))]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.FillRoomTextureWithSprites))]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.FillRoomZonesWithSprites))]
    public static void DungeonRoom_FillPatches(ref DungeonRoom __instance)
    {
        if (!IsUltrawide()) return;
        
        UpdateFloorWidth(__instance);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.InitializeRoom), typeof(DungeonRoomInfo))]
    [HarmonyPatch(typeof(DungeonRoom), nameof(DungeonRoom.InitializeRoom), new Type[] { })]
    public static void DungeonRoom_InitializeRoom(ref DungeonRoom __instance)
    {
        if (!IsUltrawide()) return;

        if (__instance is DungeonBossRoom)
        {
            Plugin.LOG.LogWarning("DungeonBossRoom: Aborting DungeonLevelArt/DungeonLevelBoundaries/WallDetails Adjustments");
            return;
        }

        foreach (var obj in Helpers.FindObjects("DungeonLevelArt"))
        {
            obj.transform.localScale = new Vector3(ScaleFactor, 1f, 1);
        }

        foreach (var obj in Helpers.FindObjects("DungeonLevelBoundaries"))
        {
            obj.transform.localScale = new Vector3(ScaleFactor, 1f, 1);
        }

        foreach (var obj in Helpers.FindObjectsInPath("WallDetails/"))
        {
            var t = obj.transform;
            if (TransformIsRightAngled(t))
            {
                if (TransformIsLeftSide(t))
                {
                    var localPosition = obj.transform.localPosition;
                    var newPosition = GetAdjustedLeftPosition(localPosition.x);
                    localPosition = new Vector3(newPosition, localPosition.y, localPosition.z);
                    obj.transform.localPosition = localPosition;
                }

                if (TransformIsRightSide(t))
                {
                    var localPosition = obj.transform.localPosition;
                    var newPosition = GetAdjustedRightPosition(localPosition.x);
                    localPosition = new Vector3(newPosition, localPosition.y, localPosition.z);
                    obj.transform.localPosition = localPosition;
                }
            }
        }
    }
}