using System;
using MelonLoader;

namespace TotallyNotMelonLoader
{
    public class MyMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Log("Mod has been loaded, console title will be changed in a moment...");
            MelonPrefs.RegisterCategory("TotallyNotMelonLoader", "TotallyNotMelonLoader");
            MelonPrefs.RegisterString("TotallyNotMelonLoader", "Desired Name", " ");

            Console.Title = MelonPrefs.GetString("TotallyNotMelonLoader", "Desired Name");

        }
        public override void OnModSettingsApplied()
        {
            Console.Title = MelonPrefs.GetString("TotallyNotMelonLoader", "Desired Name");
        }
    }
}
