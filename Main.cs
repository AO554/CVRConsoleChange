using System;
using MelonLoader;
using MelonLoader.ICSharpCode.SharpZipLib.Zip;

namespace CVRConsoleChange
{
    public class Main : MelonMod
    {
        internal static readonly MelonLogger.Instance log = new MelonLogger.Instance("CVRConsoleChange", ConsoleColor.Magenta);
        public static MelonPreferences_Category CVRConsoleChange;
        public static MelonPreferences_Entry<bool> Enabled;
        public static MelonPreferences_Entry<string> WindowTitleStr;

        public override void OnApplicationStart()
        {
            log.Msg("Change Process Window in Progress...");
            
            // Generate MelonLoader Preferences for this Mod
            CVRConsoleChange = MelonPreferences.CreateCategory("CVRConsoleChange", "CVRConsoleChange");
            Enabled = CVRConsoleChange.CreateEntry("Enabled", true);
            WindowTitleStr = CVRConsoleChange.CreateEntry("WindowTitle", "ChilloutVR Console");
            
            // Change Title to String...duh
            if (Enabled.Value == true)
            {
                Console.Title = (WindowTitleStr.Value);
                log.Msg("Title updated!");
            }
            else
                log.Msg("Retaining Default Console Title.");
        }
    }
}