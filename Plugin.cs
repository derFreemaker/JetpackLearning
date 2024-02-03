using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JetpackLearning.Patches;

namespace JetpackLearning
{
    public static class PluginInfo {
        public const string MOD_GUID = "Freemaker.JetpackLearning";
        public const string MOD_NAME = "JetpackLearning";
        public const string MOD_VERSION = "1.0.0.0";
    }
    
    [BepInPlugin(PluginInfo.MOD_GUID, PluginInfo.MOD_NAME, PluginInfo.MOD_VERSION)]
    public class Plugin : BaseUnityPlugin {
        private readonly Harmony _harmony = new Harmony(PluginInfo.MOD_GUID);

        public static Plugin Instance { get; private set; }

        public ManualLogSource Mls { get; private set; }
        
        private void Awake() {
            if (Instance == null) {
                Instance = this;
            }

            Mls = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.MOD_GUID);
            
            Mls.LogInfo("Mod is active");
            
            _harmony.PatchAll(typeof(Plugin));
            _harmony.PatchAll(typeof(PricePatch));
        }
    }
}