using AmongUs.Data.Player;
using AmongUs.Data.Settings;
using HarmonyLib;

namespace TownOfUs.Patches
{
    [HarmonyPatch(typeof(PlayerData), nameof(PlayerData.FileName), MethodType.Getter)]
    [HarmonyPatch(typeof(SettingsData), nameof(SettingsData.FileName), MethodType.Getter)]
    public static class SaveManagerPatch
    {
        public static void Postfix(ref string __result)
        {
            __result += "_TouReactivated";
        }
    }
}

