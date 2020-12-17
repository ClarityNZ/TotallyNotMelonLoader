using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
