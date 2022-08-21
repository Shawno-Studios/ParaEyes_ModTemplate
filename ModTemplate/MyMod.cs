using BepInEx;
using HarmonyLib;
using ModTemplate;
using System.Reflection;

namespace ModTemplate
{
    [BepInPlugin("modAuthor.modName", "modName", "modVersion")]
    public class MyMod : BaseUnityPlugin
    {
        #region Mod Info

        public const string modName = "Mod Template";
        public const string modVersion = "1.0.0.0";
        public const string modAuthor = "Gurrenm4";

        #endregion


        /// <summary>
        /// This code runs automatically as soon as the mod is registered by BepInEx.
        /// </summary>
        public void Awake()
        {
            // <-- Ignore this code --> //
            new Harmony($"{modAuthor}_{modName}").PatchAll(Assembly.GetExecutingAssembly());


            // <-- Your code goes below here --> //

            Logger.LogInfo($"{modName} has loaded");
        }
    }
}
