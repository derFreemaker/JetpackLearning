using GameNetcodeStuff;
using HarmonyLib;

namespace JetpackLearning.Patches {
    
    [HarmonyPatch(typeof(PlayerControllerB))]
    public class PlayerControllerBPatch {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        // ReSharper disable once InconsistentNaming
        public static void InfiniteSprintPatch(ref float ___sprintMeter) {
            ___sprintMeter = 1f;
        }
    }
}               