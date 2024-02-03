using HarmonyLib;

namespace JetpackLearning.Patches {
    
    [HarmonyPatch(typeof(Terminal))]    
    public class PricePatch {

        [HarmonyPatch(nameof(Terminal.SetItemSales))]
        [HarmonyPostfix]
        // ReSharper disable once InconsistentNaming
        private static void StorePrices(ref Item[] ___buyableItemsList) {
            ___buyableItemsList[9].creditsWorth = 0;
        }
    }
}