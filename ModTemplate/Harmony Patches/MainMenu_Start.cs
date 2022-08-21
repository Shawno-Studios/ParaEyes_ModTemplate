using BepInEx.Logging;
using HarmonyLib;

namespace ModTemplate.Harmony_Patches
{
    /// <summary>
    /// This is an example of how Harmony Patches look.
    /// </summary>

    [HarmonyPatch(typeof(MainMenu), "Start")]
    internal class MainMenu_Start
    {
        [HarmonyPrefix]
        internal static bool Prefix(MainMenu __instance) // __instance is the actual instance that called the method.
        {
            // This is a "Prefix" harmony patch. It will run BEFORE the game will run it's original
            // method, which in this case is MainMenu.Start


            // <-- Your Code Here --> //

            

            return true; // return true (RECOMMENDED) if you want the game's original code to run.
                         // Otherwise false (Experienced modders only!). Will not affect Postfix.
        }

        [HarmonyPostfix]
        internal static void Postfix(MainMenu __instance)
        {
            // This is a "Postfix" harmony patch. It will run your code AFTER the game has already ran
            // it's original method.


            // <-- Your Code Here --> //

            
        }
    }
}
